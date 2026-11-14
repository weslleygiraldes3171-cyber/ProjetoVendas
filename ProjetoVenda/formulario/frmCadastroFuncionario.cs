using ProjetoVenda.controller;
using ProjetoVenda.model;
using ProjetoVenda.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;


namespace ProjetoVenda.view
{
    public partial class frmCadastroFuncionario : Form
    {
        private FuncionarioControle controle;
        private Funcionario funcionario;
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            controle = new FuncionarioControle();
        }

        private void limpaTudo()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtComplemento.Clear();

            txtUsuario.Clear();
            txtSenha.Clear();
            txtSenha1.Clear();

        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string telefone = this.txtTelefone.Text;
            string rua = this.txtRua.Text;
            string numero = this.txtNumero.Text;
            string cep = this.txtCep.Text;
            string complemento = this.txtComplemento.Text;

            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;
            string senha1 = this.txtSenha1.Text;

            bool adm = (this.cbxAdm.SelectedIndex == 0)? false: true;

            if (senha != senha1)
            {
                MessageBox.Show(
                    "Senha não coencidem",
                    "senha incorretas",
                     MessageBoxButtons.OK, MessageBoxIcon.Error
                 );
                return;

            }
            Funcionario funcionario = new Funcionario
            {
                nome = nome,
                telefone = telefone,
                rua = rua,
                numero = numero,
                cep = cep,
                complemento = complemento,
                usuario = usuario,
                senha = senha,
                adm = adm
            };

            FuncionarioControle controle = new FuncionarioControle();
            bool resp = controle.criarFuncionario(funcionario);

            if (resp)
            {

                MessageBox.Show("Funcionário cadastrado com sucesso",
                    "cadastro realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTudo();
                carregarFuncionario();

            }
            else
            {

                MessageBox.Show("Erro ao cadastrar funcionario",
                    "Cadastro de funcionario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        
        private void carregarFuncionario()
        {
            List<Funcionario> lista = controle.pegarTudo();
            this.dgvEmployee.DataSource = lista;
            this.dgvEmployee.Columns["senha"].Visible = false;
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            carregarFuncionario();
            this.cbxAdm.SelectedIndex = 0;
        }
    }
}
