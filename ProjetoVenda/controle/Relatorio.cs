using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {
        public Document gerarNota()
        {
            var documento = Document.Create(conteudo=>{
                conteudo.Page(pagina =>
                {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);

                    pagina.Header().Column(coluna => {
                        coluna.Item().AlignCenter().Text("Cupom de Venda").FontSize(18);
                        coluna.Item().LineHorizontal(2);
                        coluna.Item().AlignCenter().Text("Maravilhas de chocolate").FontSize(20);
                        coluna.Item().AlignCenter().Text(@"Av.Indepedencia, 1050 
Bairro dos Bandeirantes");
                    });


                    pagina.Content();


                    pagina.Footer().Column(coluna =>
                    {
                        coluna.Item().LineHorizontal(0.5f);

                        

                    });




                });
            
            
            
            });
            return documento;
            

        }
        public void salvarPdf()
        {
            var dialogo = new SaveFileDialog
            {
                Title = "Salvar Documento",
                FileName = "nota.pdf",
                Filter = "(PDF)|*.pdf"
            };
            if(dialogo.ShowDialog() == DialogResult.OK)
            {
                var documento = gerarNota();
                documento.GeneratePdf(dialogo.FileName);

            }
        }   
    }
}
