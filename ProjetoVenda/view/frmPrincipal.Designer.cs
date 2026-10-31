namespace ProjetoVenda.view
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            bntCadFuncionario = new Button();
            btnCadProduto = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnSaida = new Button();
            panel2 = new Panel();
            painelPrincipal = new Panel();
            btnUser = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bntCadFuncionario
            // 
            bntCadFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntCadFuncionario.Location = new Point(27, 180);
            bntCadFuncionario.Name = "bntCadFuncionario";
            bntCadFuncionario.Size = new Size(179, 99);
            bntCadFuncionario.TabIndex = 2;
            bntCadFuncionario.Text = "Cadastrar funcionario";
            bntCadFuncionario.UseVisualStyleBackColor = true;
            bntCadFuncionario.Click += bntCadFuncionario_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(27, 314);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(179, 99);
            btnCadProduto.TabIndex = 3;
            btnCadProduto.Text = "Cadastrar Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 53);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 4;
            label1.Text = "Seja Bem Vindo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 100);
            label2.Name = "label2";
            label2.Size = new Size(165, 40);
            label2.TabIndex = 5;
            label2.Text = "Funcionario\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnSaida);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bntCadFuncionario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCadProduto);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 602);
            panel1.TabIndex = 6;
            // 
            // btnSaida
            // 
            btnSaida.Location = new Point(27, 543);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(179, 32);
            btnSaida.TabIndex = 6;
            btnSaida.Text = "Sair";
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(223, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 78);
            panel2.TabIndex = 7;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(223, 78);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(887, 524);
            painelPrincipal.TabIndex = 8;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(27, 434);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(179, 85);
            btnUser.TabIndex = 7;
            btnUser.Text = "Perfil do Usuario";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1110, 602);
            Controls.Add(painelPrincipal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Tela Principal";
            Load += frmPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button bntCadFuncionario;
        private Button btnCadProduto;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel painelPrincipal;
        private Button btnSaida;
        private Button btnUser;
    }
}