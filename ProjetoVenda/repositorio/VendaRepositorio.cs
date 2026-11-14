using MySqlConnector;
using ProjetoVenda.controller;
using ProjetoVenda.database;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;


namespace ProjetoVenda.repository
{
    internal class VendaRepositorio
    {
        public bool cadatrarVenda(Venda venda)
        {
            using MySqlConnection conector = BandoDeDados.conexao();
            using MySqlTransaction transacao = conector.BeginTransaction();
            try
            {
                //bloquear os produtos
                foreach (var item in venda.itens.OrderBy(item => item.cod_produto))
                {
                    string sqlBloquieo = @"SELECT * FROM produtos
                            WHERE cod_produto = @cod_produto FOR UPDATE";
                    using var cmdBloqueio = new MySqlCommand(sqlBloquieo, conector, transacao);
                    cmdBloqueio.Parameters.AddWithValue("@cod_produto", item.cod_produto);
                    using var cursor = cmdBloqueio.ExecuteReader();
                    if (!cursor.Read())
                    {
                        throw new Exception("Erro de registro!");
                    }
                    int quantidade = cursor.GetInt32("quantidade");
                    if (quantidade < item.quantidade)
                    {
                        throw new Exception($"Quantidade indisponivel do produto: {item.nomeProduto}");
                    }
                }
                //registrar a venda
                string sqlVenda = @"INSERT  INTO vendas (id_funcionario)
                             VALUES (@id_funcionario)";
                using var cmdVenda = new MySqlCommand(sqlVenda, conector, transacao);
                cmdVenda.Parameters.AddWithValue("@id_funcionario", venda.id_funcionario);
                cmdVenda.ExecuteNonQuery();
                venda.cod_venda = (int)cmdVenda.LastInsertedId;

                //registrar os itens
                foreach (Item item  in venda.itens)
                {
                    string sqlItem = @"INSERT INTO itens
                        (cod_venda, cod_produto, quantidade, preco)
                        VALUES
                        (@cod_venda, @cod_produto, @quantidade, @preco)";
                    using MySqlCommand cmdItem = new MySqlCommand(sqlItem, conector, transacao);
                    cmdItem.Parameters.AddWithValue("@cod_venda", venda.cod_venda);
                    cmdItem.Parameters.AddWithValue("@cod_produto", item.cod_produto);
                    cmdItem.Parameters.AddWithValue("@quantidade", item.quantidade);
                    cmdItem.Parameters.AddWithValue("@preco", item.preco);
                    int linhaAlterada  = cmdItem.ExecuteNonQuery();
                    if (linhaAlterada != 1)
                    {
                        throw new Exception($"Erro ao cadastrar o produto: {item.nomeProduto}");
                    }

                    // atualizar a qauntidade do produto
                    string sqlQuantidade = @"UPDATE produtos SET quantidade = quantidade - @quantidade
                                WHERE cod_produto = @cod_produto";
                    using MySqlCommand cmdQuantidade = new MySqlCommand(sqlQuantidade , conector, transacao);
                    cmdQuantidade.Parameters.AddWithValue("@quantidade", item.quantidade);
                    cmdQuantidade.Parameters.AddWithValue("@cod_produto", item.cod_produto);
                    linhaAlterada = cmdQuantidade.ExecuteNonQuery();
                    if (linhaAlterada != 1)
                    {
                        throw new Exception($"Erro ao atualizar a quantidade do produto: {item.nomeProduto}");
                    }

                }

                transacao.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                throw ex;
            }


             
        }
    }
}
