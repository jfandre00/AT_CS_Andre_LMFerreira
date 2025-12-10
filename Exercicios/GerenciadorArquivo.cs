using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class GerenciadorArquivo
    {
        // Método genérico para gravar qualquer linha de texto
        public static void GravarLinha(string nomeArquivo, string linha)
        {
            try
            {
                // O 'using' garante que o arquivo fecha mesmo se der erro (substitui o FecharArquivo)
                // O 'true' ativa o modo Append (adicionar no final)
                using (StreamWriter sw = new StreamWriter(nomeArquivo, true))
                {
                    sw.WriteLine(linha);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gravar no arquivo: {ex.Message}");
            }
        }

        // Método genérico para ler todas as linhas
        public static List<string> LerArquivo(string nomeArquivo)
        {
            List<string> linhas = new List<string>();

            if (!File.Exists(nomeArquivo))
            {
                return linhas; // Retorna lista vazia se arquivo não existe
            }

            try
            {
                using (StreamReader sr = new StreamReader(nomeArquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        linhas.Add(linha);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler arquivo: {ex.Message}");
            }

            return linhas;
        }
    }
}
