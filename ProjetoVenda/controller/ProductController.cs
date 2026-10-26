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
        
        public bool createProduct(Product product)
        {
            int id_funcionario = Session.userAuth.id_funcionario;
            product.id_funcionario = id_funcionario;
            //chamar a repository
            repository.createProduct(product);
            return true;
        }
        public  List<Product> getAll()
        {
            return repository.getAll();
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
