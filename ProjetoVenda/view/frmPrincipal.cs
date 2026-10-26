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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            string username = Session.username;
            bool isAdmin = Session.isAdmin;
            //this.lblUsername.Text = username;
        }

        private void bntCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            frm.ShowDialog();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadProduto frm = new frmCadProduto();
            frm.ShowDialog();
        }
    }
}
