using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.model;
using ProjetoVenda.repository;



namespace ProjetoVenda.controller
{
    internal class VendaControle
    {
        EmployeeController employeeController;
        VendaRepositorio vendaRepositorio;

        public VendaControle()
        {
            employeeController = new EmployeeController();
            vendaRepositorio = new VendaRepositorio();
           
        }

        public bool cadVenda(List<Item> itens)
        {
            Employee? funcionario = employeeController.usuarioAutenticado();
            if (funcionario == null)
            {
                throw new Exception("Usuario não autenticado");
            }
            int idFuncionario = funcionario.id_funcionario;
            Venda venda = new Venda 
            {
                id_funcionario = idFuncionario,
                itens = itens
            };

            vendaRepositorio.cadatrarVenda(venda);
            return true;
        }
    }
}
