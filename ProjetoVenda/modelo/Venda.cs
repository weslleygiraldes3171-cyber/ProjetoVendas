using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoVenda.model
{
    internal class Venda
    {
        public int cod_venda {  get; set; }
        public int id_funcionario { get; set; }
        public DateTime registro { get; set; }

        public List<Item> itens {  get; set; } = new List<Item>();

        public decimal total => itens.Sum(i > )
        public string nomeFuncionario { get; set; }
    }
}
