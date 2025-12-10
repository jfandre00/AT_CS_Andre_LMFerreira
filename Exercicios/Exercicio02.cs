using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio02
    {
        public void Executar()
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            char[] caracteres = nome.ToCharArray(); // converti a string em um array de char
            char[] resultado = new char[caracteres.Length]; // array de char do mesmo tamanho do original

            for (int i = 0; i < caracteres.Length; i++)
            {
                char c = caracteres[i];

                if (c == ' ') // manter espaços
                {
                    resultado[i] = ' ';
                    continue; // não faz processamento abaixo e pula para a próxima iteração
                }

                char letra = char.ToLower(c); // converter p/ minúscula p/ facilitar a verificação

                // Chamando o método para remover acentos (criado abaixo)
                letra = RemoverAcentos(letra);

                if (letra < 'a' || letra > 'z') // se não for letra, manter o caractere original
                {
                    resultado[i] = c;
                    continue; // pular para a próxima iteração
                }

                char deslocada = (char)(letra + 2); // deslocar 2 posições

                if (deslocada > 'z') // se ultrapassar 'z', voltar ao início do alfabeto
                {
                    deslocada = (char)(deslocada - 26);
                }

                // Manter maiúscula/minúscula

                if (char.IsUpper(c))
                {
                    deslocada = char.ToUpper(deslocada);
                }

                resultado[i] = deslocada; // armazenar o caractere deslocado no array de resultado

            }

            Console.WriteLine("\nNome cifrado:");
            Console.WriteLine(new string(resultado));

        }

                // Método que criei para remover acentos
                private static char RemoverAcentos(char caractere) 
        {
                    switch (caractere)
                    {
                            case 'á':
                            case 'à':
                            case 'ã':
                            case 'â':
                            case 'ä':
                                return 'a';
                            case 'é':
                            case 'è':
                            case 'ê':
                            case 'ë':
                                return 'e';
                            case 'í':
                            case 'ì':
                            case 'î':
                            case 'ï':
                                return 'i';
                            case 'ó':
                            case 'ò':
                            case 'õ':
                            case 'ô':
                            case 'ö':
                                return 'o';
                            case 'ú':
                            case 'ù':
                            case 'û':
                            case 'ü':
                                return 'u';
                            case 'ç':
                                return 'c';
                            default:
                                return caractere; // retorna o ele mesmo se não for uma letra acentuada
                    }

                }

    }
}

