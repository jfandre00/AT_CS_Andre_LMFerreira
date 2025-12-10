namespace AT_CS_Andre_LMFerreira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // adicionei para o ex12 aparecer os ícones de telefone e email corretamente no console
            // pesquisei no stackoverflow sobre como fazer isso
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("AT DE Fundamentos de Desenvolvimento com C#");
                Console.WriteLine("Feito por André L. M. Ferreira");
                Console.WriteLine("1 - Exercício 1");
                Console.WriteLine("2 - Exercício 2");
                Console.WriteLine("3 - Exercício 3");
                Console.WriteLine("4 - Exercício 4");
                Console.WriteLine("5 - Exercício 5");
                Console.WriteLine("6 - Exercício 6");
                Console.WriteLine("7 - Exercício 7");
                Console.WriteLine("8 - Exercício 8");
                Console.WriteLine("9 - Exercício 9 (Parte B)");
                Console.WriteLine("10 - Exercício 10");
                Console.WriteLine("11 - Exercício 11");
                Console.WriteLine("12 - Exercício 12");
                Console.WriteLine("13 - Exercicio 9 (Parte A)");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção: ");

                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out opcao))
                {
                    opcao = -1; // Entrada inválida
                }

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        new Exercicios.Exercicio01().Executar();
                        break;
                    case 2:
                        new Exercicios.Exercicio02().Executar();
                        break;
                    case 3:
                        new Exercicios.Exercicio03().Executar();
                        break;
                    case 4:
                        new Exercicios.Exercicio04().Executar();
                        break;
                    case 5:
                        new Exercicios.Exercicio05().Executar();
                        break;
                    case 6:
                        new Exercicios.Exercicio06().Executar();
                        break;
                    case 7:
                        new Exercicios.Exercicio07().Executar();
                        break;
                    case 8:
                        new Exercicios.Exercicio08().Executar();
                        break;
                    case 9:
                        new Exercicios.Exercicio09().Executar();
                        break;
                    case 10:
                        new Exercicios.Exercicio10().Executar();
                        break;
                    case 11:
                        new Exercicios.Exercicio11().Executar();
                        break;
                    case 12:
                        new Exercicios.Exercicio12().Executar();
                        break;
                    case 13:
                        new Exercicios.Exercicio09A().Executar();
                        break;
                    case 0:
                        Console.WriteLine("Espero que tenha gostado do meu AT!");
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }

            } while (opcao != 0);
        }
    }
}
