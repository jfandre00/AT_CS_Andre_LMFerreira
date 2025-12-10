using System.Globalization;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    public static class InputUtils
    {
        // A partir do ex09, coloquei todos os métodos de verificação de input aqui

        // Lê string e não deixa vir vazia
        public static string LerString(string mensagem)
        {
            string entrada;
            do
            {
                Console.Write(mensagem);
                entrada = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Erro: O texto não pode ser vazio.");
                }
            } while (string.IsNullOrWhiteSpace(entrada));
            return entrada;
        }

        // Tenta ler um int. Se falhar pede de novo
        public static int LerInteiro(string mensagem)
        {
            int valor;
            while (true)
            {
                Console.Write(mensagem);
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    return valor;
                }
                Console.WriteLine("Erro: Digite um número inteiro válido.");
            }
        }

        // Tenta ler um decimal (aceita ponto ou vírgula)
        public static decimal LerDecimal(string mensagem)
        {
            decimal valor;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();

                // Tenta converter aceitando qualquer cultura (ponto ou virgula)
                // como fizemos em aula
                if (decimal.TryParse(entrada.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                {
                    return valor;
                }
                Console.WriteLine("Erro: Digite um valor numérico válido (ex: 10.50)");
            }
        }
    }
}