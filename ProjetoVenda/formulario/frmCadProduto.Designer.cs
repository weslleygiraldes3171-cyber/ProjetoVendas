namespace ProjetoVenda.view
{
    partial class frmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProduto));
            dgvProduto = new DataGridView();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPagina = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            txtMarca = new TextBox();
            label6 = new Label();
            txtNome = new TextBox();
            label5 = new Label();
            txtPreco = new TextBox();
            label4 = new Label();
            txtQuantidade = new NumericUpDown();
            label3 = new Label();
            btnCadProduto = new Button();
            label2 = new Label();
            btnDelete = new Button();
            cbxQuantidadeItens = new ComboBox();
            btnUpadete = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduto
            // 
            dgvProduto.AllowUserToAddRows = false;
            dgvProduto.AllowUserToDeleteRows = false;
            dgvProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Location = new Point(11, 267);
            dgvProduto.MultiSelect = false;
            dgvProduto.Name = "dgvProduto";
            dgvProduto.ReadOnly = true;
            dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduto.Size = new Size(761, 422);
            dgvProduto.TabIndex = 6;
            dgvProduto.CellContentClick += dgvProduto_CellContentClick;
            dgvProduto.CellDoubleClick += dgvProduto_CellDoubleClick;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Left;
            btnAnterior.Location = new Point(3, 14);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(88, 48);
            btnAnterior.TabIndex = 9;
            btnAnterior.Text = "< Anterior ";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Anchor = AnchorStyles.Right;
            btnProximo.Location = new Point(686, 14);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(88, 48);
            btnProximo.TabIndex = 10;
            btnProximo.Text = "Proximo >";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPagina
            // 
            lblPagina.Location = new Point(342, 30);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(77, 15);
            lblPagina.TabIndex = 11;
            lblPagina.Text = "Página 1 de 5";
            lblPagina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvProduto, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 264F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(783, 772);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnCadProduto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cbxQuantidadeItens);
            panel1.Controls.Add(btnUpadete);
            panel1.Location = new Point(11, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 258);
            panel1.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtMarca.Location = new Point(112, 72);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(564, 23);
            txtMarca.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(112, 138);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 14;
            label6.Text = "Quantidade";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtNome.Location = new Point(112, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(564, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(114, 182);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 13;
            label5.Text = "Quantidades de items na lista";
            // 
            // txtPreco
            // 
            txtPreco.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPreco.Location = new Point(112, 110);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$000,00";
            txtPreco.Size = new Size(158, 23);
            txtPreco.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(112, 92);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 13;
            label4.Text = "Preço";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtQuantidade.Location = new Point(112, 156);
            txtQuantidade.Maximum = new decimal(new int[] { -1981284352, -1966660860, 0, 0 });
            txtQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(157, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(112, 54);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 13;
            label3.Text = "Marca:";
            // 
            // btnCadProduto
            // 
            btnCadProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadProduto.Location = new Point(282, 110);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(394, 50);
            btnCadProduto.TabIndex = 4;
            btnCadProduto.Text = "Cadastro De Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(112, 16);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 13;
            label2.Text = "Nome do Produto:";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(474, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(202, 50);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Excluir Produto";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnExcluir_Click;
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "10", "20", "50", "100" });
            cbxQuantidadeItens.Location = new Point(113, 200);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(163, 23);
            cbxQuantidadeItens.TabIndex = 12;
            cbxQuantidadeItens.SelectedIndexChanged += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // btnUpadete
            // 
            btnUpadete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpadete.Enabled = false;
            btnUpadete.Location = new Point(282, 166);
            btnUpadete.Name = "btnUpadete";
            btnUpadete.Size = new Size(182, 50);
            btnUpadete.TabIndex = 8;
            btnUpadete.Text = "Atualizar Produto";
            btnUpadete.UseVisualStyleBackColor = true;
            btnUpadete.Click += btnUpadete_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.Controls.Add(btnAnterior);
            panel2.Controls.Add(lblPagina);
            panel2.Controls.Add(btnProximo);
            panel2.Location = new Point(3, 695);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 74);
            panel2.TabIndex = 1;
            // 
            // frmCadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(783, 772);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadProduto";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            Load += frmCadProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProduto;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPagina;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox txtNome;
        private TextBox txtMarca;
        private TextBox txtPreco;
        private NumericUpDown txtQuantidade;
        private Button btnCadProduto;
        private Button btnDelete;
        private Button btnUpadete;
        private ComboBox cbxQuantidadeItens;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
    }
}