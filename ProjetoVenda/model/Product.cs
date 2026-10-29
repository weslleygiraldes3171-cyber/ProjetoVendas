using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.model
{
    internal class Product
    {

        public int cod_produto {  get; set; }
        public int id_funcionario { get; set; }
        public int quantidade { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public int preco { get; set; }
        public DateTime data_registro { get; set; }

        public void validate()
        {
            if (preco <= 0)
            {
                throw new ArgumentException("Preço não pode ser zerado");
            }
            if (quantidade < 0)
            {
                throw new ArgumentException("Qunatidade tem ser maior ou igual 0");
            }
        }
    }
}
