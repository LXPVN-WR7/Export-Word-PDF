using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;

namespace Repositório_Export_Word_PDF
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] nome = new string[5];
            String[] endereco = new string[5];
            double[] compra = new double[5];
            DateTime[] data = new DateTime[5];
            int contador = 0;
            Char resposta;
            String resp;


            Console.WriteLine(@"
            ----------------------------------------------------------------------
            | SEJA BEM VINDO AO SISTEMA DE CADASTRAMENTO DE NOTA FISCAL DO SENAI |
            ----------------------------------------------------------------------
            ");

            do
            {

                Console.Write("Informe o seu nome: ");
                nome[contador] = Console.ReadLine();

                Console.Write("\nInforme o seu endereço: ");
                endereco[contador] = Console.ReadLine();

                Console.Write("\nInforme o valor da compra: ");
                compra[contador] = double.Parse(Console.ReadLine());

                Console.Write("\nInforme a data da compra: ");
                data[contador] = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Gostaria de cadastrar mais uma nota ? (S/N)");
                resposta = char.ToUpper(char.Parse(Console.ReadLine()));

                if (resposta == 'S')
                {
                    contador++;
                }
                else
                {
                    contador = contador + 10;
                }

            } while (contador <= 5);

            Console.WriteLine(@"
--------
| MENU |
--------

Selecione uma opção a seguir:
-------
| (1) | - Listar notas cadastradas
-------
-------
| (2) | - Gerar arquivo Word da nota fiscal do usuário
-------
            ");

            resp = Console.ReadLine();

            switch (resp)
            {

                case "1":

                    contador = 0;

                    Console.WriteLine("\nUsuários cadastrados:\n");
                    for (int i = 0; i < 10; i++)
                    {
                        if (!string.IsNullOrEmpty(nome[i]))
                        {
                            Console.WriteLine($"Nome: {nome[i]} \nEndereço: {endereco[i]} \nValor da compra: {compra[i]} \nData da compra: {data[i]}\n");
                        }
                    }
                    break;

                case "2":

                    Console.WriteLine("Selecione o usuário:");

                        contador = 0;
                    do
                    {
                        if (!string.IsNullOrEmpty(nome[contador]))
                        {
                            Console.WriteLine($"({contador + 1}) - Nome: {nome[contador]}");
                        }
                        contador++;
                    } while (contador <= 5);

                    Console.Write("\nSelecione o usuário: ");
                    resp = Console.ReadLine();

                    switch (resp)
                    {
                        case "1":
                            break;

                        case "2":
                            break;

                        case "3":
                            break;

                        case "4":
                            break;

                        case "5":
                            break;
                    }


                    break;

            }



            // // Criando um novo documento 
            // Document MacDonalds = new Document();
            // // Criando uma seção dentro do documento (MacDonalds)
            // // A cada seção criada, uma nova página é adicionada
            // Section secaoCapa = MacDonalds.AddSection();
            // // Insere um título na primeira página 
            // Paragraph titulo = secaoCapa.AddParagraph();
            // // Insiro na minha variável título o valor da string Título muito bonito 
            // // No meu documento aparecerá "Título muito bonito"
            // titulo.AppendText("Título muito bonito\n\n");
            // //  Alinha horizontalmente 
            // titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

            // ParagraphStyle batata = new ParagraphStyle(MacDonalds);
            // // Define o nome da classe 
            // batata.Name = "Cor do título";
            // // Transforma a propriedade TextColor de Azul escuro
            // batata.CharacterFormat.TextColor = Color.DarkBlue;
            // // Transforma a propriedade Bold em True    
            // batata.CharacterFormat.Bold = true;
            // // Adicionar o estilo e colocar como usável no nosso documento
            // MacDonalds.Styles.Add(batata);

            // titulo.ApplyStyle(batata.Name);

            // Paragraph conteudo = secaoCapa.AddParagraph();

            // conteudo.AppendText("Mussum Ipsum, cacilds vidis litro abertis. Praesent vel viverra nisi. Mauris aliquet nunc non turpis scelerisque, eget. Mauris nec dolor in eros commodo tempor. Aenean aliquam molestie leo, vitae iaculis nisl. A ordem dos tratores não altera o pão duris. Pra lá , depois divoltis porris, paradis.");

            // MacDonalds.SaveToFile(@"Saida\exemploWord.docx", FileFormat.Docx);

        }
    }
}
