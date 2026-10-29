using MySqlConnector;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoVenda.repository;

namespace ProjetoVenda.controller
{
    internal class ProductController
    {
        private ProductRepository repository;

        public ProductController()
        {
            repository = new ProductRepository();
        }
        
        
        public  List<Product> getAll()
        {
            return repository.getAll();
        }
        public List<Product> getListPage(int qtd, int page)
        {
            return repository.getListPage(qtd, page);
        }
        public int countPage(int qtdItens)
        {
            int totalProducts = repository.countProduct();
            return (int)Math.Ceiling((decimal)totalProducts / qtdItens);
        }
        public bool createProduct(Product product)
        {
            int id_funcionario = Session.userAuth.id_funcionario;
            product.id_funcionario = id_funcionario;
            product.validate();
            // fazer o cadastro
            repository.createProduct(product);
            return true;
        }
        public bool updateProduct (Product product)
        {
            return repository.updateProduct(product);
        }
        public bool deleteProduct (Product product)
        {
            return repository.deleteProduct(product.cod_produto);
        }

    }
}
