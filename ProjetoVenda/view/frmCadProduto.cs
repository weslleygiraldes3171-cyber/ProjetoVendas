using ProjetoVenda.controller;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ProjetoVenda.view
{
    public partial class frmCadProduto : Form
    {
        private ProductController controller;
        private Product? produtoSelecionado;
        private int totalPage = 5;
        private int pageAtual = 1;
        private int totalByPage = 5;


        public frmCadProduto()
        {
            InitializeComponent();
            controller = new ProductController();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string marca = this.txtMarca.Text;
            int preco = Convert.ToInt32(this.txtPreco.Text);
            int quantidade = Convert.ToInt32(this.txtQuantidade.Text);

            // Enviar os dados do Produto
            Product product = new Product
            {
                nome = nome,
                marca = marca,
                preco = preco,
                quantidade = quantidade
            };

            bool resp = controller.createProduct(product);
            if (resp)
            {
                MessageBox.Show("Produto cadastrado com sucesso",
                    "Cadastro Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearField();
                loadProduct();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar Produto",
                    "Cadastro de Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            loadProduct();
            //int page = controller.countPage(5);
            //lblPagina.Text = $"1 de {page}";
        }
        private void loadProduct()
        {
            List<Product> list = controller.getListPage(totalPage, pageAtual);
            this.dgvProduto.DataSource = list;
            this.dgvProduto.Columns["id_funcionario"].Visible = false;
            totalPage = controller.countPage(totalPage);
            if (pageAtual > totalPage)
            {
                pageAtual = totalPage;
            }
            updateLblPage();

        }
        private void clearField()
        {
            this.txtNome.Clear();
            this.txtMarca.Clear();
            this.txtPreco.Clear();
            this.txtQuantidade.Value = 0;
        }

        private void btnUpadete_Click(object sender, EventArgs e)
        {
            //evento update
            produtoSelecionado.nome = this.txtNome.Text;
            produtoSelecionado.marca = this.txtMarca.Text;
            produtoSelecionado.preco = Convert.ToInt32(this.txtPreco.Text);
            produtoSelecionado.quantidade = (int)this.txtQuantidade.Value;
            bool resp = controller.updateProduct(produtoSelecionado);
            if (resp)
            {
                MessageBox.Show(
                    "Produto atrualizado com sucesso",
                    "Atualização do Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                clearField();
                loadProduct();
                this.btnUpadete.Enabled = false;
                this.btnDelete.Enabled = false;
                produtoSelecionado = null;
            }
            else
            {
                MessageBox.Show(
                    "Erro ao atualizar o oproduto",
                    "Atualização do produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
            }
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow linha = this.dgvProduto.Rows[e.RowIndex];
            Product? produto = linha.DataBoundItem as Product;

            this.txtNome.Text = produto.nome;
            this.txtMarca.Text = produto.marca;
            this.txtPreco.Text = produto.preco.ToString();
            this.txtQuantidade.Value = produto.quantidade;
            produtoSelecionado = produto;
            this.btnUpadete.Enabled = true;
            this.btnDelete.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool resp = controller.deleteProduct(produtoSelecionado);
            if (resp)
            {
                MessageBox.Show(
                    "Produto excluido com sucesso",
                    "Exclusão de Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                clearField();
                loadProduct();
                this.btnUpadete.Enabled = false;
                this.btnDelete.Enabled = false;
                produtoSelecionado = null;
            }
            else
            {
                MessageBox.Show(
                    "Erro ao excluir o oproduto",
                    "Exclusão do produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );


            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pageAtual > 1)
            {
                pageAtual--;
                updateLblPage();
                loadProduct();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (pageAtual < totalPage)
            {
                pageAtual++;
                updateLblPage();
                loadProduct();
            }
        
        }
        private void updateLblPage()
        {
            this.lblPagina.Text = $" {pageAtual} de {totalPage}";
        }
    }
}
