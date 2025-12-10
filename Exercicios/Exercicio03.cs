using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio03
    {
        public void Executar()
        {
            Console.WriteLine("Calculadora Matemática - Exercício 3");

            double numero1 = LerNumero("Digite o primeiro número: "); // método criado abaixo
            double numero2 = LerNumero("Digite o segundo número: ");

            Console.WriteLine("\nEscolha a operação abaixo: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int opcao = LerOpcao(); // método criado abaixo

            double resultado = 0;
            bool operacaoValida = true;

            switch (opcao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        operacaoValida = false;
                    }
                    break;
            }

            if (operacaoValida)
            {
                Console.WriteLine($"\nResultado: {resultado}");
            }
        }


        public static double LerNumero(string mensagem)
        {
            double valor;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Entre com um número válido.");
                }
            }
        }

        private static int LerOpcao()
        {
            Console.WriteLine("Digite a opcao (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= 4)
            // se for um número entre 1 e 4
            {
                return opcao;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                return LerOpcao(); // chamada recursiva até obter uma opção válida
            }
        }
    }
}

