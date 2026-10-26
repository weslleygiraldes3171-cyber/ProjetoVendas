using ProjetoVenda.database;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.model;
using ProjetoVenda.repository;

namespace ProjetoVenda.controller
{
    internal class EmployeeController
    {

        public static bool login(string username, string password)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(username);
            if (resp == null)
            {
                return false;
            }

            bool validatePassword;
            try
            {
                validatePassword = BCrypt.Net.BCrypt.Verify(password, resp.senha);
            }catch(Exception ex)
            {
                validatePassword = false;
            }

            if ( !validatePassword )
            {
                return false;
            }
            // gravar os dados do usuario logado
            Session.userAuth = resp;
            return true;
        }

        public bool createEmployee(string nome, string telefone, string rua, 
                                    string numero, string cep, string complemento,
                                        string usuario, string senha)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(usuario);
            if (resp != null)
            {

                return false;

            }


            string hash = BCrypt.Net.BCrypt.HashPassword(senha);
            Employee funcionario = new Employee
            {
                nome = nome,
                telefone = telefone,
                rua = rua,
                numero = numero,
                cep = cep,
                complemento = complemento,
                usuario = usuario,
                senha = hash
            };
            repository.createEmployee(funcionario);

            return true;
        }
    }
}
