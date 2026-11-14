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
        private ProdutoControle controle;
        private Produto? produtoSelecionado;
        private int totalDePagina = 5;
        private int pageAtual = 1;
        private int totalPorPagina = 5;


        public frmCadProduto()
        {
            InitializeComponent();
            controle = new ProdutoControle();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string marca = this.txtMarca.Text;
            int preco = Convert.ToInt32(this.txtPreco.Text);
            int quantidade = Convert.ToInt32(this.txtQuantidade.Text);

            // Enviar os dados do Produto
            Produto produto = new Produto
            {
                nome = nome,
                marca = marca,
                preco = preco,
                quantidade = quantidade
            };
            try
            {
                bool resp = controle.createProduct(produto);
                if (resp)
                {
                    MessageBox.Show("Produto cadastrado com sucesso",
                        "Cadastro Produto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearField();
                    carregarProduto();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto",
                        "Cadastro de Produto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
        
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            this.cbxQuantidadeItens.SelectedIndex = 0;
            carregarProduto();
        }
        private void carregarProduto()
        {
            totalDePagina = controle.contagemDePagina(totalPorPagina);
            if (pageAtual > totalDePagina)
            {
                pageAtual = totalDePagina;
            }
            updateLblPage();
            List<Produto> list = controle.pegarListaDePagina(totalPorPagina, pageAtual);
            this.dgvProduto.DataSource = list;
            this.dgvProduto.Columns["id_funcionario"].Visible = false;
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
            bool resp = controle.atualizarProduto(produtoSelecionado);
            if (resp)
            {
                MessageBox.Show(
                    "Produto atrualizado com sucesso",
                    "Atualização do Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                clearField();
                carregarProduto();
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
            Produto? produto = linha.DataBoundItem as Produto;

            this.txtNome.Text = produto.nome;
            this.txtMarca.Text = produto.marca;
            this.txtPreco.Text = produto.preco.ToString();
            this.txtQuantidade.Value = produto.quantidade;
            produtoSelecionado = produto;
            this.btnUpadete.Enabled = true;
            this.btnDelete.Enabled = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resp = controle.excluirProduto(produtoSelecionado);
            if (resp)
            {
                MessageBox.Show(
                    "Produto excluido com sucesso",
                    "Exclusão de Produto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                clearField();
                carregarProduto();
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
                carregarProduto();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (pageAtual < totalDePagina)
            {
                pageAtual++;
                updateLblPage();
                carregarProduto();
            }

        }
        private void updateLblPage()
        {
            this.lblPagina.Text = $" {pageAtual} de {totalDePagina}";
        }

        private void cbxQuantidadeItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            // capturrar o numero
            this.totalPorPagina = int.Parse(this.cbxQuantidadeItens.Text);
            // e recacular as paginas
            carregarProduto();
        }
    }
}
