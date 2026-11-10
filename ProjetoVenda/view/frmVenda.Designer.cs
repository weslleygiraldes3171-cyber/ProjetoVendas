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
            btnAddVenda = new Button();
            dgvCarrinho = new DataGridView();
            lblPrecoTotal = new Label();
            btnCadVenda = new Button();
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
            lblPreco.Location = new Point(45, 58);
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
            // btnAddVenda
            // 
            btnAddVenda.Location = new Point(482, 81);
            btnAddVenda.Name = "btnAddVenda";
            btnAddVenda.Size = new Size(145, 23);
            btnAddVenda.TabIndex = 4;
            btnAddVenda.Text = "Adcionar item";
            btnAddVenda.UseVisualStyleBackColor = true;
            btnAddVenda.Click += btnAddVenda_Click;
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
            // lblPrecoTotal
            // 
            lblPrecoTotal.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecoTotal.Location = new Point(266, 441);
            lblPrecoTotal.Name = "lblPrecoTotal";
            lblPrecoTotal.Size = new Size(512, 78);
            lblPrecoTotal.TabIndex = 6;
            lblPrecoTotal.Text = "Total de venda: ";
            lblPrecoTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCadVenda
            // 
            btnCadVenda.Location = new Point(322, 110);
            btnCadVenda.Name = "btnCadVenda";
            btnCadVenda.Size = new Size(120, 23);
            btnCadVenda.TabIndex = 7;
            btnCadVenda.Text = "Cadastrar Venda";
            btnCadVenda.UseVisualStyleBackColor = true;
            btnCadVenda.Click += btnCadVenda_Click;
            // 
            // frmVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 569);
            Controls.Add(btnCadVenda);
            Controls.Add(lblPrecoTotal);
            Controls.Add(dgvCarrinho);
            Controls.Add(btnAddVenda);
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
        private Button btnAddVenda;
        private DataGridView dgvCarrinho;
        private Label lblPrecoTotal;
        private Button btnCadVenda;
    }
}