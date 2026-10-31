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
using ProjetoVenda.database;

namespace ProjetoVenda.view
{
    public partial class frmPerfilUsuario : Form
    {
        private EmployeeController controller;
        private Employee? funcionario;
        public frmPerfilUsuario()
        {
            InitializeComponent();
            controller = new EmployeeController();


        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {
            funcionario = controller.usuarioAutenticado();
            if(funcionario != null)
            {
                carregarDados();
            }
        }
        private void carregarDados()
        {
            this.txtNome.Text = funcionario.nome;
            this.txtTelefone.Text = funcionario.telefone;
            this.txtRua.Text = funcionario.rua;
            this.txtCep.Text = funcionario.cep;
            this.txtComplemento.Text = funcionario.complemento;
            this.txtUser.Text = funcionario.usuario;
        }
    }



}
