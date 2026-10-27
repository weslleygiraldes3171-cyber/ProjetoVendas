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
    internal class ProductRepository
    {
        private Product map(MySqlDataReader reader)
        {
            return new Product
            {
                id_funcionario = reader.GetInt32("id_funcionario"),
                cod_produto = reader.GetInt32("cod_produto"),
                nome = reader.GetString("nome"),
                marca = reader.GetString("marca"),
                quantidade = reader.GetInt32("quantidade"),
                preco = reader.GetInt32("preco_compra"),
                data_registro = reader.GetDateTime("data_registro")
            };
        }

        public List<Product> getAll()
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM produtos";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            using var reader = cmd.ExecuteReader();
             
            List<Product> list = new List<Product>();
            while (reader.Read())
            {
                list.Add(map(reader));
            }
            return list;
        }
        public List<Product> getListPage(int qtd, int page)
        {
            int offset = qtd * (page - 1);
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT * FROM produtos LIMIT @limit OFFSET @offset";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@limit", qtd);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();

            List<Product> list = new List<Product>();
            while (reader.Read())
            {
                list.Add(map(reader));
            }
            return list;
        }
        public int countProduct()
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = "SELECT COUNT(*) FROM produtos";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public int createProduct(Product product)

        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"INSERT INTO produtos(id_funcionario, nome, marca, preco_compra, quantidade)
                        VALUES         
                        (@id_funcionario, @nome, @marca, @preco, @quantidade) ";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@id_funcionario", product.id_funcionario);
            cmd.Parameters.AddWithValue("@nome", product.nome);
            cmd.Parameters.AddWithValue("@marca", product.marca);
            cmd.Parameters.AddWithValue("@preco", product.preco);
            cmd.Parameters.AddWithValue("@quantidade", product.quantidade);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }

        public bool updateProduct(Product product)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"UPDATE produtos SET nome = @nome, 
                                               marca = @marca, 
                                               preco_compra = @preco_compra, 
                                               quantidade = @quantidade
                        WHERE  cod_produto = @cod_produto";   
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@cod_produto", product.cod_produto);
            cmd.Parameters.AddWithValue("@nome", product.nome);
            cmd.Parameters.AddWithValue("@marca", product.marca);
            cmd.Parameters.AddWithValue("@preco_compra", product.preco);
            cmd.Parameters.AddWithValue("@quantidade", product.quantidade);
            return cmd.ExecuteNonQuery() > 0;
            
        }
        public bool deleteProduct(int cod_produto)
        {
            using MySqlConnection connector = Database.GetConnection();
            string sql = @"DELETE FROM produtos WHERE cod_produto = @cod_produto";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@cod_produto", cod_produto);
            return cmd.ExecuteNonQuery() > 0;

        }
        
    }

}
