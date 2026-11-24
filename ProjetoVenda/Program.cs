using ProjetoVenda.view;
using ProjetoVenda.controle;
using QuestPDF.Infrastructure;
namespace ProjetoVenda
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            ApplicationConfiguration.Initialize();
            //0Application.Run(new frmLogin());
            //Application.Run(new frmVenda());
            //Relatorio relatorio = new Relatorio();
            //relatorio.salvarPdf();
            

            while (true)
            {
                using (frmLogin login = new frmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }
                }
                using frmPrincipal principal = new frmPrincipal();
                {

                    Application.Run(principal);
                    if (principal.DialogResult != DialogResult.Retry)
                    {
                        break;
                    }
                }

            }

        }
    }
    
}
    
