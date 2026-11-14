using MySqlConnector;
using ProjetoVenda.database;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoVenda.repository
{
    internal class FuncionarioRepositorio
    {
        private Funcionario mapear(MySqlDataReader cursor)
        {
            return new Funcionario
            {
                id_funcionario = cursor.GetInt32("id_funcionario"),
                nome = cursor.GetString("nome"),
                usuario = cursor.GetString("usuario"),
                senha = cursor.GetString("senha"),
                telefone = cursor.GetString("telefone"),
                rua = (cursor.IsDBNull(cursor.GetOrdinal("rua")))? null : cursor.GetString("rua"),
                numero = cursor.GetString("numero"),
                complemento = (cursor.IsDBNull(cursor.GetOrdinal("Complemento"))) ? null : cursor.GetString("Complemento"),
                cep = cursor.GetString("CEP"),
                adm = cursor.GetBoolean("adm")

            };

        }
        
        public List<Funcionario> listarFuncionario()
        {
            using MySqlConnection connector = BandoDeDados.conexao();
            string sql = "SELECT * FROM funcionario";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            using var cursor = cmd.ExecuteReader();

            List<Funcionario> lista = new List<Funcionario>();
            while (cursor.Read())
            {
                lista.Add(mapear(cursor));
            }
            return lista;
        }
        
        public Funcionario? pegarPorNomeDeUsuario(string nomeDeUsuario)
        {

            using MySqlConnection conector = BandoDeDados.conexao();
            string sql = "SELECT * FROM funcionario WHERE usuario = @username";
            using MySqlCommand cmd = new MySqlCommand(sql, conector);
            cmd.Parameters.AddWithValue("@username", nomeDeUsuario);
            using var cursor = cmd.ExecuteReader();
            if (cursor.Read())
            {
                return mapear(cursor);
            }
            return null;
             
        }

        public int criarFuncionario(Funcionario funcionario)
        {
            using MySqlConnection connector = BandoDeDados.conexao();
            string sql = @"INSERT INTO funcionario
                            (nome, usuario, senha, telefone, rua, numero, complemento, cep, adm)
                            VALUES
                            (@nome, @usuario, @senha, @telefone, @rua, @numero, @complemento, @cep, @adm)";
            using MySqlCommand cmd = new MySqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@usuario", funcionario.usuario);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
            cmd.Parameters.AddWithValue("@rua", funcionario.rua);
            cmd.Parameters.AddWithValue("@numero", funcionario.numero);
            cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
            cmd.Parameters.AddWithValue("@cep", funcionario.cep);
            cmd.Parameters.AddWithValue("@adm", funcionario.adm);
            cmd.ExecuteNonQuery();
            return (int)cmd.LastInsertedId;
        }
    }
}
