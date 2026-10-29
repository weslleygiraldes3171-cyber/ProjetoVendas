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
        private void exibirForms(Form forms)
        {
            while (painelPrincipal.Controls.Count > 0)
            {
                painelPrincipal.Controls[0].Dispose();
            }
            forms.TopLevel = false;
            forms.FormBorderStyle = FormBorderStyle.None;
            forms.Dock = DockStyle.Fill;
            painelPrincipal.Controls.Add(forms);
            forms.Show();
        }
        private void bntCadFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            //frm.ShowDialog();
            exibirForms(frm);
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            frmCadProduto frm = new frmCadProduto();
            //frm.ShowDialog();]
            exibirForms(frm);
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            // evento para sair
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }
    }
}
