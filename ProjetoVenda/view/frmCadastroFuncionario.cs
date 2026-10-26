using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjetoVenda.controller;

namespace ProjetoVenda.view
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
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

            if (senha != senha1)
            {
                MessageBox.Show(
                    "Senha não coencidem",
                    "senha incorretas",
                     MessageBoxButtons.OK, MessageBoxIcon.Error
                 );
                return;

            }
            EmployeeController controller = new EmployeeController();
            bool resp = controller.createEmployee(nome, telefone, rua, numero, cep, complemento, usuario, senha);

            if (resp)
            {

                MessageBox.Show("Funcionário cadastrado com sucesso",
                    "cadastro realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTudo();

            }
            else
            {

                MessageBox.Show("Erro ao cadastrar funcionario",
                    "Cadastro de funcionario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        //chamar o controlador do usuario para criar o funcinario
        //solicitar ao repository se o usuario existe ou nao
    }
}
