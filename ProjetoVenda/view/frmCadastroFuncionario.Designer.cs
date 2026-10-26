namespace ProjetoVenda.view
{
    partial class frmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFuncionario));
            txtSenha = new TextBox();
            txtTelefone = new TextBox();
            txtSenha1 = new TextBox();
            txtRua = new TextBox();
            txtUsuario = new TextBox();
            txtNumero = new TextBox();
            txtCep = new TextBox();
            txtComplemento = new TextBox();
            txtNome = new TextBox();
            bntCadastrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(320, 162);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(212, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(43, 162);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(213, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(320, 214);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.PasswordChar = '*';
            txtSenha1.PlaceholderText = "Confirmar senha";
            txtSenha1.Size = new Size(213, 23);
            txtSenha1.TabIndex = 8;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(43, 214);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(213, 23);
            txtRua.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(320, 108);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário";
            txtUsuario.Size = new Size(212, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(43, 259);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Número";
            txtNumero.Size = new Size(89, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(156, 259);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 4;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(43, 310);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(213, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(43, 108);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome completo";
            txtNome.Size = new Size(213, 23);
            txtNome.TabIndex = 0;
            // 
            // bntCadastrar
            // 
            bntCadastrar.ForeColor = SystemColors.ControlText;
            bntCadastrar.Location = new Point(381, 252);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(103, 81);
            bntCadastrar.TabIndex = 9;
            bntCadastrar.Text = "Cadastro";
            bntCadastrar.UseVisualStyleBackColor = true;
            bntCadastrar.Click += bntCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(124, 26);
            label1.Name = "label1";
            label1.Size = new Size(313, 40);
            label1.TabIndex = 10;
            label1.Text = "Cadastro de Funcionario";
            label1.Click += label1_Click;
            // 
            // frmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(549, 378);
            Controls.Add(label1);
            Controls.Add(bntCadastrar);
            Controls.Add(txtNome);
            Controls.Add(txtComplemento);
            Controls.Add(txtCep);
            Controls.Add(txtNumero);
            Controls.Add(txtUsuario);
            Controls.Add(txtRua);
            Controls.Add(txtSenha1);
            Controls.Add(txtTelefone);
            Controls.Add(txtSenha);
            ForeColor = SystemColors.Highlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastroFuncionario";
            Text = "Cadastro de Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtTelefone;
        private TextBox txtSenha1;
        private TextBox txtRua;
        private TextBox txtUsuario;
        private TextBox txtNumero;
        private TextBox txtCep;
        private TextBox txtComplemento;
        private TextBox txtNome;
        private Button bntCadastrar;
        private Label label1;
    }
}