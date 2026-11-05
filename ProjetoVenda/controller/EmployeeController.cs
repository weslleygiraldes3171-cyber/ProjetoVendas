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
        private EmployeeRepository repository;

        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }
        public List<Employee> getAll()
        {
            return repository.getAll();
        }

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

        public bool createEmployee(Employee employee)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee? resp = repository.getByUsername(employee.usuario);
            if (resp != null)
            {

                return false;

            }

            string hash = BCrypt.Net.BCrypt.HashPassword(employee.senha);
            employee.senha = hash;

            repository.createEmployee(employee);
            return true;
        }
        public void deslogar()
        {
            Session.userAuth = null;
        }
        public Employee? usuarioAutenticado()
        {
            return Session.userAuth;
        }
        public bool userAdmin()
        {
            if (Session.userAuth == null)
            {
                return false;
            }
            return Session.userAuth.adm;
        }
        

    }
}