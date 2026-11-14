using MySqlConnector;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.repository;

namespace ProjetoVenda.controller
{
    internal class ProdutoControle
    {
        private ProdutoRepositorio repositorio;

        public ProdutoControle()
        {
            repositorio = new ProdutoRepositorio();
        }
        
        
        public  List<Produto> pegarTodos()
        {
            return repositorio.pegarTodos();
        }
        public List<Produto> pegarListaDePagina(int qtd, int page)
        {
            return repositorio.pegarListaDePagina(qtd, page);
        }
        public int contagemDePagina(int qtdItens)
        {
            int totalProducts = repositorio.contagemDeProduto();
            return (int)Math.Ceiling((decimal)totalProducts / qtdItens);
        }
        public bool createProduct(Produto produto)
        {
            int id_funcionario = Sessao.usuarioAutenticado.id_funcionario;
            produto.id_funcionario = id_funcionario;
            produto.validate();
            // fazer o cadastro
            repositorio.criarProduto(produto);
            return true;
        }
        public bool atualizarProduto (Produto produto)
        {
            return repositorio.atualizarProduto(produto);
        }
        public bool excluirProduto (Produto produto)
        {
            return repositorio.apagarProduto(produto.cod_produto);
        }

    }
}
