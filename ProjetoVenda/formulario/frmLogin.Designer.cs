namespace ProjetoVenda.view
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUser = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(50, 130);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(184, 23);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(50, 174);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(184, 23);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.MintCream;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.ForeColor = SystemColors.ControlText;
            btnEntrar.Location = new Point(75, 216);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(127, 37);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar ";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(84, 281);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(105, 15);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "esqueceu a senha?";
         
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 112);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Usuário:";
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 156);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Senha:";
       
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
           
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(285, 306);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtSenha;
        private Button btnEntrar;
        private LinkLabel linkLabel2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}