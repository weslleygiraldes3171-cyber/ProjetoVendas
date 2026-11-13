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
        private VendaControle vendaControle;
        private List<Item> carrinho = new List<Item>();
        public frmVenda()
        {
            InitializeComponent();
            productController = new ProductController();
            vendaControle = new VendaControle();

        }
        private void loadProduct()
        {
            List<Product> list = productController.getAll();
            cbxProduto.DataSource = list;
            cbxProduto.DisplayMember = "nome";
            cbxProduto.ValueMember = "cod_produto";
        }
        private void configCarrinho()
        {
            this.dgvCarrinho.AutoGenerateColumns = false;
            this.dgvCarrinho.Columns.Clear();
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Produto",
                    Name = "colunaProduto",
                    DataPropertyName = "nomeProduto",

                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Marca",
                    Name = "colunaMarca",
                    DataPropertyName = "marca",

                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Quantidade",
                    Name = "colunaQuantidade",
                    DataPropertyName = "quantidade",

                });
            this.dgvCarrinho.Columns.Add(
                new DataGridViewButtonColumn
                {
                    HeaderText = "Excluir",
                    Name = "colunaExcluir",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = true
                });

            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Preço Unitario",
                    Name = "colunaPreco",
                    DataPropertyName = "PrecoReal",
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "C2"
                    }

                });


            this.dgvCarrinho.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "Sub Total",
                    Name = "colunaSubTotal",
                    DataPropertyName = "subTotal",
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "C2"
                    }

                });
        }

        public void atualizarCarrinho()
        {
            this.dgvCarrinho.DataSource = this.carrinho.ToList();
            this.btnCadVenda.Visible = this.carrinho.Count() > 0;
            decimal total = this.carrinho.Sum(item => item.subTotal);
            this.lblPrecoTotal.Text = $"Total da venda {total:c2}";
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            loadProduct();
            configCarrinho();
            atualizarCarrinho();
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = cbxProduto.SelectedItem as Product;
            this.lblPreco.Text = $"Preço Unitario {product.precoReal:C2}";
            this.lblQuantidade.Text = $"Quantidade disponivel {product.quantidade}";
            this.numQuantidade.Maximum = product.quantidade;
            this.numQuantidade.Value = (this.numQuantidade.Maximum > 0) ? 1 : 0;
        }

        private void btnAddVenda_Click(object sender, EventArgs e)
        {
            Product product = this.cbxProduto.SelectedItem as Product;
            int quantidade = (int)this.numQuantidade.Value;
            if (quantidade < 1)
            {
                return;
            }

            Item? itemExistente = this.carrinho.FirstOrDefault(item => item.cod_produto == product.cod_produto);
            if (itemExistente == null)
            {
                Item novoItem = new Item
                {
                    cod_produto = product.cod_produto,
                    quantidade = quantidade,
                    preco = product.preco,
                    nomeProduto = product.nome,
                    marca = product.marca,
                };
                this.carrinho.Add(novoItem);
            }
            else
            {
                itemExistente.quantidade += quantidade;
            }
            product.quantidade -= quantidade;
            this.cbxProduto.SelectedItem = product;
            cbxProduto_SelectedIndexChanged(this, EventArgs.Empty);

            atualizarCarrinho();

        }

        private void btnCadVenda_Click(object sender, EventArgs e)
        {
            decimal total = this.carrinho.Sum(item => item.subTotal);
            DialogResult comfimar = MessageBox.Show(
                $"Deseja efetuar a venda no valor {total:C2} ",
                "Confiamar Venda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if (comfimar == DialogResult.No)
            {
                return;
            }
            try
            {
                bool resposta = vendaControle.cadVenda(this.carrinho);
                if (resposta)
                {
                    carrinho.Clear();
                    frmVenda_Load(this, EventArgs.Empty);
                    atualizarCarrinho();
                    MessageBox.Show("Venda cadastrada com sucesso!!!");
                }
                else
                {
                    MessageBox.Show
                        ("Erro ao caddastrar Venda!", "Erro no cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show
                    ($"Erro: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            if(this.dgvCarrinho.Columns[e.ColumnIndex].Name == ("colunaExcluir"))
            {
                excluirItemCarrinho(e.RowIndex);
            }
        }
        private  void excluirItemCarrinho(int indice)
        {
            DialogResult comfimar = MessageBox.Show(
                $"Deseja excluir o item",
                "Excluir item",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if (comfimar == DialogResult.No)
            {
                return;
            }
            this.carrinho.RemoveAt(indice);
            atualizarCarrinho();

        }
    }
}
