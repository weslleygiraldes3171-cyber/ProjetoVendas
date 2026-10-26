using ProjetoVenda.view;

namespace ProjetoVenda
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            //Application.Run(new frmLogin());
            Application.Run(new frmCadProduto());
            //using (frmLogin login = new frmLogin())
            //{
            //    if (login.ShowDialog() == DialogResult.OK)
            //    {
            //        Application.Run(new frmPrincipal());
            //    }
            //}

        }
    }
    
}
    
