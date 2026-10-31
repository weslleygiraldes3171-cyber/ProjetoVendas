namespace ProjetoVenda.view
{
    partial class frmPerfilUsuario
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
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtRua = new TextBox();
            txtCep = new TextBox();
            txtComplemento = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(116, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(637, 23);
            txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(116, 83);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(124, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(116, 131);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(305, 23);
            txtRua.TabIndex = 5;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(524, 131);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(169, 23);
            txtCep.TabIndex = 7;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(116, 181);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(305, 23);
            txtComplemento.TabIndex = 9;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(116, 220);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(137, 23);
            txtUser.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 91);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 13;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 139);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 14;
            label3.Text = "Rua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 189);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 15;
            label4.Text = "Complemento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 228);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 16;
            label5.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 139);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 17;
            label6.Text = "CEP";
            // 
            // frmPerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(txtComplemento);
            Controls.Add(txtCep);
            Controls.Add(txtRua);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Name = "frmPerfilUsuario";
            Text = "perfilUsuario";
            Load += frmPerfilUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtRua;
        private TextBox txtCep;
        private TextBox txtComplemento;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}