using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio10
    {
        public void Executar()
        {
            // gerador de números aleatórios
            Random random = new Random();

            //entre 1 e 50 
            int numeroSecreto = random.Next(1, 51);

            int tentativasMaximas = 5;
            bool acertou = false;

            Console.Clear();
            Console.WriteLine("Jogo de Adivinhação - Exercício 10");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 50.");
            Console.WriteLine($"Você tem {tentativasMaximas} tentativas.\n");

            // Loop das tentativas (de 1 até 5)
            for (int i = 1; i <= tentativasMaximas; i++)
            {
                Console.Write($"Tentativa {i} de {tentativasMaximas}: ");

                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out int palpite))
                {
                    Console.WriteLine("Erro: Por favor, digite um número válido!");
                    i--; // não conta essa tentativa
                    continue;
                }

                if (palpite < 1 || palpite > 50)
                {
                    Console.WriteLine("Erro: O número deve estar entre 1 e 50!");
                    i--;
                    continue;
                }

                // Verificação de Vitória
                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("\nPARABÉNS! Você acertou o número secreto!");
                    acertou = true;
                    break;
                }
                else
                {
                    if (palpite < numeroSecreto)
                        Console.WriteLine("DICA: O número secreto é MAIOR.");
                    else
                        Console.WriteLine("DICA: O número secreto é MENOR.");

                    int restantes = tentativasMaximas - i;
                    if (restantes > 0)
                    {
                        Console.WriteLine($"Restam {restantes} tentativas.\n");
                    }
                }
            }

            if (!acertou)
            {
                Console.WriteLine("\nSuas tentativas acabaram! Que pena.");
                Console.WriteLine($"O número secreto era: {numeroSecreto}");
            }

            JogarNovamente();
        }


        private void JogarNovamente()
        {
            Console.Write("\nDigite 'S' para jogar novamente ou qualquer outra tecla para sair: ");
            string resposta = Console.ReadLine().Trim().ToUpper();
            if (resposta == "S")
            {
                Executar();
            }
            else
            {
                Console.WriteLine("Obrigado por jogar! Até a próxima.");
            }
        }
    }
}
