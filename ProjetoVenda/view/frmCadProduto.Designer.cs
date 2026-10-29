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
            txtNome = new TextBox();
            txtMarca = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new NumericUpDown();
            btnCadProduto = new Button();
            label1 = new Label();
            dgvProduto = new DataGridView();
            btnDelete = new Button();
            btnUpadete = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPagina = new Label();
            cbxQuantidadeItens = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(58, 68);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(350, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(58, 103);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(350, 23);
            txtMarca.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(58, 132);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "R$000,00";
            txtPreco.Size = new Size(163, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(260, 133);
            txtQuantidade.Maximum = new decimal(new int[] { -1981284352, -1966660860, 0, 0 });
            txtQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(148, 23);
            txtQuantidade.TabIndex = 3;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(154, 174);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(182, 50);
            btnCadProduto.TabIndex = 4;
            btnCadProduto.Text = "Cadastro De Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 20);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 5;
            label1.Text = "Cadastro de Produto ";
            // 
            // dgvProduto
            // 
            dgvProduto.AllowUserToAddRows = false;
            dgvProduto.AllowUserToDeleteRows = false;
            dgvProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Location = new Point(12, 269);
            dgvProduto.MultiSelect = false;
            dgvProduto.Name = "dgvProduto";
            dgvProduto.ReadOnly = true;
            dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduto.Size = new Size(666, 399);
            dgvProduto.TabIndex = 6;
            dgvProduto.CellContentClick += dgvProduto_CellContentClick;
            dgvProduto.CellDoubleClick += dgvProduto_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(440, 174);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 50);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Excluir Produto";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpadete
            // 
            btnUpadete.Enabled = false;
            btnUpadete.Location = new Point(440, 94);
            btnUpadete.Name = "btnUpadete";
            btnUpadete.Size = new Size(182, 50);
            btnUpadete.TabIndex = 8;
            btnUpadete.Text = "Atualizar Produto";
            btnUpadete.UseVisualStyleBackColor = true;
            btnUpadete.Click += btnUpadete_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(12, 703);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(88, 48);
            btnAnterior.TabIndex = 9;
            btnAnterior.Text = "< Anterior ";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(590, 703);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(88, 48);
            btnProximo.TabIndex = 10;
            btnProximo.Text = "Proximo >";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPagina
            // 
            lblPagina.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPagina.Location = new Point(260, 721);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(77, 15);
            lblPagina.TabIndex = 11;
            lblPagina.Text = "Página 1 de 5";
            lblPagina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxQuantidadeItens
            // 
            cbxQuantidadeItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQuantidadeItens.FormattingEnabled = true;
            cbxQuantidadeItens.Items.AddRange(new object[] { "10", "20", "50", "100" });
            cbxQuantidadeItens.Location = new Point(12, 240);
            cbxQuantidadeItens.Name = "cbxQuantidadeItens";
            cbxQuantidadeItens.Size = new Size(163, 23);
            cbxQuantidadeItens.TabIndex = 12;
            cbxQuantidadeItens.SelectedIndexChanged += cbxQuantidadeItens_SelectedIndexChanged;
            // 
            // frmCadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(698, 772);
            Controls.Add(cbxQuantidadeItens);
            Controls.Add(lblPagina);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnUpadete);
            Controls.Add(btnDelete);
            Controls.Add(dgvProduto);
            Controls.Add(label1);
            Controls.Add(btnCadProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtMarca);
            Controls.Add(txtNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadProduto";
            Text = "Cadastro de Produto";
            Load += frmCadProduto_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtMarca;
        private TextBox txtPreco;
        private NumericUpDown txtQuantidade;
        private Button btnCadProduto;
        private Label label1;
        private DataGridView dgvProduto;
        private Button btnDelete;
        private Button btnUpadete;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPagina;
        private ComboBox cbxQuantidadeItens;
    }
}