namespace ProjetoVenda.view
{
    partial class frmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbxProduto = new ComboBox();
            lblPreco = new Label();
            lblQuantidade = new Label();
            numQuantidade = new NumericUpDown();
            btnCadVenda = new Button();
            dgvCarrinho = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).BeginInit();
            SuspendLayout();
            // 
            // cbxProduto
            // 
            cbxProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProduto.FormattingEnabled = true;
            cbxProduto.Location = new Point(2, 12);
            cbxProduto.Name = "cbxProduto";
            cbxProduto.Size = new Size(776, 23);
            cbxProduto.TabIndex = 0;
            cbxProduto.SelectedIndexChanged += cbxProduto_SelectedIndexChanged;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(45, 73);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(125, 15);
            lblPreco.TabIndex = 1;
            lblPreco.Text = "Preço Unitario R$00,00";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(45, 110);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(137, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade disponivel x ";
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(322, 81);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 3;
            // 
            // btnCadVenda
            // 
            btnCadVenda.Location = new Point(322, 110);
            btnCadVenda.Name = "btnCadVenda";
            btnCadVenda.Size = new Size(145, 23);
            btnCadVenda.TabIndex = 4;
            btnCadVenda.Text = "Cadastrar Venda";
            btnCadVenda.UseVisualStyleBackColor = true;
            // 
            // dgvCarrinho
            // 
            dgvCarrinho.AllowUserToAddRows = false;
            dgvCarrinho.AllowUserToDeleteRows = false;
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrinho.Location = new Point(12, 153);
            dgvCarrinho.Name = "dgvCarrinho";
            dgvCarrinho.ReadOnly = true;
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrinho.Size = new Size(766, 285);
            dgvCarrinho.TabIndex = 5;
            // 
            // frmVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCarrinho);
            Controls.Add(btnCadVenda);
            Controls.Add(numQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(cbxProduto);
            Name = "frmVenda";
            Text = "Cadastro de Vendas ";
            Load += frmVenda_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxProduto;
        private Label lblPreco;
        private Label lblQuantidade;
        private NumericUpDown numQuantidade;
        private Button btnCadVenda;
        private DataGridView dgvCarrinho;
    }
}