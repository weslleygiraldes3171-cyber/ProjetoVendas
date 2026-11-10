using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.model
{
    internal class Item
    {
        public int cod_produto { get; set; }
        public int cod_itens { get; set; }
        public int cod_venda { get; set; }
        public int quantidade { get; set; }
        public int preco { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }

        public DateTime data_registro { get; set; }

        public decimal precoReal => preco / 100m;
        public decimal subTotal => precoReal * quantidade;
    }
}
