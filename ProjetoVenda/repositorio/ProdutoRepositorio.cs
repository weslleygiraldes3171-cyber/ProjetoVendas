using MySqlConnector;
using ProjetoVenda.controller;
using ProjetoVenda.database;
using ProjetoVenda.database;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoVenda.repository
{
    internal class ProdutoRepositorio
    {
        private Produto mapear(MySqlDataReader cursor)
        {
            return new Produto
            {
                id_funcionario = cursor.GetInt32("id_funcionario"),
                cod_produto = cursor.GetInt32("cod_produto"),
                nome = cursor.GetString("nome"),
                marca = cursor.GetString("marca"),
                quantidade = cursor.GetInt32("quantidade"),
                preco = cursor.GetInt32("preco_compra"),
                data_registro = cursor.GetDateTime("data_registro")
            };
        }

        public List<Produto> pegarTodos()
        {
            using MySqlConnection conector = BandoDeDados.conexao();
            string sql = "SELECT * FROM produtos";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            using var cursor = cmd.ExecuteReader();
             
            List<Produto> lista = new List<Produto>();
            while (cursor.Read())
            {
                lista.Add(mapear(cursor));
            }
            return lista;
        }
        public List<Produto> pegarListaDePagina(int quantidade, int pagina)
        {
            int offset = quantidade * (pagina - 1);
            using MySqlConnection conector = BandoDeDados.conexao();
            string sql = "SELECT * FROM produtos LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@limit", quantidade);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var cursor = cmd.ExecuteReader();

            List<Produto> lista = new List<Produto>();
            while (cursor.Read())
            {
                lista.Add(mapear(cursor));
            }
            return lista;
        }
        public int contagemDeProduto()
        {
            using MySqlConnection conector = BandoDeDados.conexao();
            string sql = "SELECT COUNT(*) FROM produtos";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public int criarProduto(Produto product)

        {
            using MySqlConnection conector = BandoDeDados.conexao();
            string sql = @"INSERT INTO produtos(id_funcionario, nome, marca, preco_compra, quantidade)
                        VALUES         
                        (@id_funcionario, @nome, @marca, @preco, @quantidade) ";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@id_funcionario", product.id_funcionario);
            cmd.Parameters.AddWithValue("@nome", product.nome);
            cmd.Parameters.AddWithValue("@marca", product.marca);
            cmd.Parameters.AddWithValue("@preco", product.preco);
            cmd.Parameters.AddWithValue("@quantidade", product.quantidade);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public bool atualizarProduto(Produto produto)
        {
            using MySqlConnection conector = BandoDeDados.conexao();
            string sql = @"UPDATE produtos SET nome = @nome, 
                                               marca = @marca, 
                                               preco_compra = @preco_compra, 
                                               quantidade = @quantidade
                        WHERE  cod_produto = @cod_produto";   
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@cod_produto", produto.cod_produto);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@marca", produto.marca);
            cmd.Parameters.AddWithValue("@preco_compra", produto.preco);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            return cmd.ExecuteNonQuery() > 0;
            
        }
        public bool apagarProduto(int cod_produto)
        {
            using MySqlConnection conector = BandoDeDados.conexao();
            string sql = @"DELETE FROM produtos WHERE cod_produto = @cod_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@cod_produto", cod_produto);
            return cmd.ExecuteNonQuery() > 0;

        }
        
    }

}
