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
            SuspendLayout();
            // 
            // bntCadFuncionario
            // 
            bntCadFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntCadFuncionario.Location = new Point(193, 142);
            bntCadFuncionario.Name = "bntCadFuncionario";
            bntCadFuncionario.Size = new Size(357, 99);
            bntCadFuncionario.TabIndex = 2;
            bntCadFuncionario.Text = "Cadastrar funcionario";
            bntCadFuncionario.UseVisualStyleBackColor = true;
            bntCadFuncionario.Click += bntCadFuncionario_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.Location = new Point(195, 291);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(355, 99);
            btnCadProduto.TabIndex = 3;
            btnCadProduto.Text = "Cadastrar Produto";
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 25);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 4;
            label1.Text = "Seja Bem Vindo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(300, 73);
            label2.Name = "label2";
            label2.Size = new Size(165, 40);
            label2.TabIndex = 5;
            label2.Text = "Funcionario\r\n";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadProduto);
            Controls.Add(bntCadFuncionario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Tela Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bntCadFuncionario;
        private Button btnCadProduto;
        private Label label1;
        private Label label2;
    }
}