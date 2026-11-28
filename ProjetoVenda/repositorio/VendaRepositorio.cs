using MySqlConnector;
using ProjetoVenda.controller;
using ProjetoVenda.database;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;


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

        public List<Venda> ListarVendasMes(int mes, int ano)
        {
            DateTime dataInicial = new DateTime(ano, mes, 1);
            DateTime dataFinal = dataInicial.AddMonths(1);

            string sql = @"SELECT 
                    v.*,
                    f.nome AS nome_funcionario,
                    i.*,
                    p.nome, p.marca
                FROM vendas v
                JOIN funcionario f
	                ON f.id_funcionario = v.id_funcionario
                JOIN itens i
	                ON i.cod_venda = v.cod_venda
                JOIN produtos p
	                ON p.cod_produto = i.cod_produto
                WHERE v.`data/hora` >= ""2026-11-01-"" AND v.`data/hora` < ""2026-12-01""
                ORDER BY v.`data/hora`, v.cod_venda, p.cod_produto
                ;";
            using MySqlConnection conector = BandoDeDados.conexao();
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@dataInicial", dataInicial);
            cmd.Parameters.AddWithValue("@dataFinal", dataFinal);

            MySqlDataReader cursor = cmd.ExecuteReader();
            List<Venda> vendas = new List<Venda>();
            while (cursor.Read())
            {
                int cod_venda = cursor.GetInt32("cod_venda");
                Venda? venda = vendas.Find(v => v.cod_venda == cod_venda);
                if(venda == null)
                {
                    venda = new Venda
                    {
                        cod_venda = cursor.GetInt32("cod_venda"),
                        id_funcionario = cursor.GetInt32("id_funcionario"),
                        registro = cursor.GetDateTime("registro"),
                        nomeFuncionario = cursor.GetString("nomeFuncionario")
                    };
                    
                    if (!cursor.IsDBNull("cod_item"))
                    {
                        Item item = new Item
                        {
                            cod_itens = cursor.GetInt32("cod_item"),
                            cod_venda = cod_venda,
                            cod_produto = cursor.GetInt32("id_produto"),
                            quantidade = cursor.GetInt32("quantidade"),
                            preco = cursor.GetInt32("preco"),
                            nomeProduto = cursor.GetString("nome"),
                            marca = cursor.GetString("marca")
                        };
                        venda.itens.Add(item);

                    }
                }
            }
            return vendas;

        }
    }
}

