using ProjetoVenda.model;
using ProjetoVenda.repository;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {
        public void salvarPdf(Document documento)
        {
            // pasta temporaria da máquina
            string pasta = Path.GetTempPath();

            // nome do pdf com a chave UUID
            string nomeArquivo = $"doc_{Guid.NewGuid()}.pdf";

            // A combinação da pasta com o arquvio do local
            string caminho = Path.Combine(pasta, nomeArquivo);

            documento.GeneratePdf(caminho);

            // essa etapa ele já abri o arquivo automaticamente
            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true

            });
        }
        
        public Document gerarNota(List<Item> itens)
        {
            DateTime data = DateTime.Now;

            DateTime dataInicial = itens.Min(venda  => venda.data_registro);
            DateTime dataFinal = itens.Max(venda => venda.data_registro);

            // um documento em que o conteúodo é igual a vazio
            var documento = Document.Create(conteudo =>
            { //criando o conteudo

                conteudo.Page(pagina =>
                {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(fonte => fonte.FontSize(6));

                    //repete em toda pagina
                    pagina.Header().Column(coluna =>
                    {
                        coluna.Item().AlignCenter().Text("Mercadinho da Cristina").SemiBold().FontSize(15);
                        coluna.Item().PaddingBottom(6).AlignCenter().Text("CNPJ: 00.000.000./0000-00").SemiBold().FontSize(7.5f);
                        coluna.Item().PaddingBottom(6).AlignCenter().Text(@"Endereço: Rua Florinda de Alves, N°1540
Votorantim/SP - CEP: 00000-00").FontSize(5.5f);
                        coluna.Item().PaddingBottom(6).LineHorizontal(1f);
                        coluna.Item().AlignCenter().Text("CUPOM DE VENDA").FontSize(10);
                        coluna.Item().PaddingBottom(8);
                        coluna.Item().LineHorizontal(0.5f);

                    });



                    // conteúdo principal
                    pagina.Content().Column(coluna =>
                    { //criando conteúdo
                        coluna.Item().Row(linha =>
                        {
                            //cabeçalho dos itens
                            linha.ConstantItem(20).Text("ITEM").FontSize(6);
                            linha.RelativeItem(2).Text("DESCRIÇÃO").FontSize(6);
                            linha.RelativeItem().Text("QTD").FontSize(6).AlignRight();
                            linha.RelativeItem().Text("PREÇO").FontSize(6).AlignRight();
                            linha.RelativeItem().Text("TOTAL").FontSize(6).AlignRight();

                        });
                        coluna.Item().PaddingBottom(3).LineHorizontal(0.5f);
                        // os itens descritos


                        for (int i = 0; i < itens.Count; i++)
                        {
                            Item item = itens[i];

                            coluna.Item().Row(linha =>
                            {
                                linha.ConstantItem(20).Text($"{i + 1}").FontSize(6);
                                linha.RelativeItem(2).Text(item.nomeProduto).FontSize(6);
                                linha.RelativeItem().AlignRight().Text($"{item.quantidade}").ToString();
                                linha.RelativeItem().AlignRight().Text($"{item.precoReal:C2}").ToString();
                                linha.RelativeItem().AlignRight().Text($"{item.subTotal:C2}").ToString();


                            });
                        }
                        coluna.Item().PaddingBottom(3).LineHorizontal(0.5f);
                        coluna.Item().Row(linha =>
                        {
                            decimal total = itens.Sum(i => i.subTotal);
                            linha.RelativeItem().Text("Total").FontSize(6);
                            linha.RelativeItem().AlignRight().Text($"{total:C2}").ToString();


                        });

                    });
                    //repete em toda pagina
                    // Rodapé
                    pagina.Footer().Column(coluna =>
                    {
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Text($"DATA: {data:dd/MM/yyyy HH:mm:ss}").FontSize(5).Bold();
                        coluna.Item().AlignCenter().Text("Mercadinho da Cristina agradece sua compra, volte sempre!").FontSize(6).Italic();
                    });
                });


            });

            return documento;
        }
        private void resumo(IContainer conteudo, List<Venda> ListaDeVendas)
        {
            int quantidadeDeVenda = ListaDeVendas.Count();
            Venda? maiorVenda = ListaDeVendas.OrderByDescending(venda=>venda.total).FirstOrDefault();
            Venda? menorVenda = ListaDeVendas.OrderBy(venda => venda.total).FirstOrDefault();
            conteudo.Column(coluna =>
            {
                coluna.Item()
                .Background(Colors.LightBlue.Darken1)
                .Padding(8)
                .Border(0.5f, Colors.LightGreen.Darken2)
                .DefaultTextStyle(e => e.FontColor(Colors.White))
                .Text("Resumo Geral");

                coluna.Item().Row(linha =>
                {
                    linha.RelativeItem().Text($"Maior venda {maiorVenda.total}");
                    linha.RelativeItem().Text($"Menor venda {menorVenda.total}");
                    linha.RelativeItem().Text($"Total de vendas: {quantidadeDeVenda}");
                });
            }
                );
            }
        private void rankFuncionario(IContainer conteudo, List<Venda> ListaDeVendas)
        {
            var funcionario = ListaDeVendas.GroupBy(venda => new
            {
                venda.id_funcionario,
                venda.nomeFuncionario
            }).Select(grupo => new
            {
                id_funcionario = grupo.Key.id_funcionario,
                nome = grupo.Key.nomeFuncionario,
                quntidade = grupo.Count(),
                total = grupo.Sum(venda => venda.total)
            }).OrderByDescending(funcionario => funcionario.total).ToList();
            conteudo.Column(coluna =>
            {
                coluna.Item()
                .Background(Colors.LightBlue.Darken1)
                .Padding(8)
                .Border(0.5f, Colors.LightGreen.Darken2)
                .DefaultTextStyle(e => e.FontColor(Colors.White))
                .Text("Ranking dos Funcionario");

                coluna.Item().Table(tabela =>
                {
                    tabela.ColumnsDefinition(coluna =>
                    {
                        coluna.ConstantColumn(20);
                        coluna.ConstantColumn(40);
                        coluna.RelativeColumn(2);
                        coluna.ConstantColumn(40);
                        coluna.RelativeColumn();
                    });
                    tabela.Header(cabecalho =>
                    {
                        cabecalho.Cell().Text("#");
                        cabecalho.Cell().Text("id");
                        cabecalho.Cell().Text("nome");
                        cabecalho.Cell().Text("QTD");
                        cabecalho.Cell().Text("Total");
                    });
                    int pos = 1;
                    foreach(var funcionario in funcionario)
                    {
                        tabela.Cell().Text($"{pos}°")
                    }
                });
            });
        }

        private void demonstratrivo(IContainer conteudo, List<Venda> ListaDeVendas)
        {
            decimal totalVendido = ListaDeVendas.Sum(venda => venda.total);
            conteudo.Column(coluna =>
            {
            coluna.Item()
            .Background(Colors.LightBlue.Darken1)
            .Padding(8)
            .Border(0.5f, Colors.LightGreen.Darken2)
            .DefaultTextStyle(e => e.FontColor(Colors.White))
            .Text("Demonstrativo de Vendas");

                coluna.Item().Row(linha =>
                {
                    linha.RelativeItem().Text($"Maior venda {maiorVenda.total}");
                    linha.RelativeItem().Text($"Menor venda {menorVenda.total}");
                    linha.RelativeItem().Text($"Total de vendas: {quantidadeDeVenda}");
                });
            }
                );
        }
        public Document gerarRelatoioMensal(List<Venda> listaDeVendas)
        {
            DateTime data = DateTime.Now;

            var documento = Document.Create(conteudo =>
            {
                conteudo.Page(pagina =>
                {
                    pagina.Size(PageSizes.A4);
                    pagina.Margin(10);
                    pagina.DefaultTextStyle(estilo => estilo.FontSize(12));

                    pagina.Header().Column(coluna =>
                    {
                        coluna.Item().Text("Sonho de Chocolate");
                        coluna.Item().Text("CNPJ: 00.000.000./0000-00");

                    });

                    pagina.Content().Column(coluna =>
                    {
                        
                    });

                    pagina.Footer().Column(coluna =>
                    {
                        coluna.Item().Row(linha =>
                        {
                            linha.RelativeItem().Text($"{data:dd/MM/yyyy HH:mm:ss}");
                            linha.RelativeItem().Text(texto =>
                            {
                                texto.Span("Pagina");
                                texto.CurrentPageNumber();
                                texto.Span(" de ");
                                texto.TotalPages();

                            });
                        });
                    });


                });

            });

            return documento;
        }


    }
}
