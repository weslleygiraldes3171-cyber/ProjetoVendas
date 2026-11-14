using ProjetoVenda.database;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.model;
using ProjetoVenda.repository;

namespace ProjetoVenda.controller
{
    internal class FuncionarioControle
    {
        private FuncionarioRepositorio repositorio;

        public FuncionarioControle()
        {
            repositorio = new FuncionarioRepositorio();
        }
        public List<Funcionario> pegarTudo()
        {
            return repositorio.listarFuncionario();
        }

        public static bool sessao(string usuario, string senha)
        {
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? resp = repositorio.pegarPorNomeDeUsuario(usuario);
            if (resp == null)
            {
                return false;
            }

            bool senhaValidada;
            try
            {
                senhaValidada = BCrypt.Net.BCrypt.Verify(senha, resp.senha);
            }catch(Exception ex)
            {
                senhaValidada = false;
            }

            if ( !senhaValidada )
            {
                return false;
            }
            // gravar os dados do usuario logado
            Sessao.usuarioAutenticado = resp;
            return true;
        }

        public bool criarFuncionario(Funcionario funcionario)
        {
            FuncionarioRepositorio repositorio = new FuncionarioRepositorio();
            Funcionario? resp = repositorio.pegarPorNomeDeUsuario(funcionario.usuario);
            if (resp != null)
            {

                return false;

            }

            string senhacript = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = senhacript;

            repositorio.criarFuncionario(funcionario);
            return true;
        }
        public void sair()
        {
            Sessao.usuarioAutenticado = null;
        }
        public Funcionario? usuarioAutenticado()
        {
            return Sessao.usuarioAutenticado;
        }
        public bool userAdmin()
        {
            if (Sessao.usuarioAutenticado == null)
            {
                return false;
            }
            return Sessao.usuarioAutenticado.adm;
        }
        

    }
}