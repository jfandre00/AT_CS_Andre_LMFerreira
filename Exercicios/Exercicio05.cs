using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio05
    {
        // Observação importante sobre o enunciado:
        // --------------------------------------------------------------
        // O exercício solicita que o código exiba uma mensagem especial
        // caso faltem menos de 6 meses para a formatura
        //
        // Como a data de formatura é fixa no código e deve ser no futuro,
        // essa condição só será verdadeira se estivermos realmente a menos
        // de 6 meses do evento. Ou seja: dependendo da data atual real,
        // pode ser impossível testar manualmente esse cenário
        //
        // Mantive a data exatamente como o enunciado exige, mas deixo
        // registrada a observação, pois compreendi essa limitação lógica
        // --------------------------------------------------------------
        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("Tempo restante para a formatura - Exercício 5\n");


            DateTime dataFormatura = new DateTime(2026, 12, 15);

            DateTime dataAtual;

            // Entrada e validação da data atual
            while (true)
            {
                Console.Write("Digite a data atual (dd/MM/yyyy): ");

                if (!DateTime.TryParse(Console.ReadLine(), out dataAtual))
                {
                    Console.WriteLine("Data inválida! Tente novamente.\n");
                    continue;
                }

                if (dataAtual > DateTime.Today)
                {
                    Console.WriteLine("Erro: A data informada não pode ser no futuro!\n");
                    continue;
                }

                break;
            }

            // Se a formatura já passou
            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("\nParabéns! Você já deveria estar formado!");
                Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                Console.ReadLine();
                return;
            }

            // Cálculo de anos, meses e dias restantes
            int anos = dataFormatura.Year - dataAtual.Year;
            int meses = dataFormatura.Month - dataAtual.Month;
            int dias = dataFormatura.Day - dataAtual.Day;

            // Ajustes quando o dia atual é maior que o dia da formatura
            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            }

            // Ajuste quando o mês atual ainda não foi alcançado
            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"\nFaltam {anos} ano(s), {meses} mes(es) e {dias} dia(s) para sua formatura!");

            // Mensagem especial (menos de 6 meses)
            bool menos6Meses =
                anos == 0 &&
                (meses < 6 || (meses == 5 && dias == 0)); // exatamente 6 meses ou menos

            if (menos6Meses)
            {
                Console.WriteLine("\nA reta final chegou! Prepare-se para a formatura!");
            }

            Console.WriteLine("\nPressione ENTER para voltar ao menu...");
            Console.ReadLine();
        }
    }
}
