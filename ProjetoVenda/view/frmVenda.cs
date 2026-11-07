using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjetoVenda.controller;
using ProjetoVenda.model;
using ProjetoVenda.repository;



namespace ProjetoVenda.view
{
    public partial class frmVenda : Form
    {
        private ProductController productController;
        public frmVenda()
        {
            InitializeComponent();
            productController = new ProductController();
        }
        private void loadProduct()
        {
            List<Product> list = productController.getAll();
            cbxProduto.DataSource = list;
            cbxProduto.DisplayMember = "nome";
            cbxProduto.ValueMember = "cod_produto";
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = cbxProduto.SelectedItem as Product;
            this.lblPreco.Text = $"Preço Unitario R$ {product.preco}";
            this.lblQuantidade.Text = $"Quantidade disponivel {product.quantidade}";
            this.numQuantidade.Maximum = product.quantidade;
            this.numQuantidade.Value =(this.numQuantidade.Maximum>0)? 1 : 0;
        }
    }
}
