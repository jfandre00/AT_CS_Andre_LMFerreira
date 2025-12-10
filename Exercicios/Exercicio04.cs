using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio04
    {
        public void Executar()
        {
            Console.Clear(); // Limpa a tela antes de iniciar o exercício
            Console.WriteLine("Dias até o próximo aniversário - Exercício 4\n");

            DateTime dataNascimento;

            // data de nascimento com validação
            while (true)
            {
                Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");

                if (DateTime.TryParse(Console.ReadLine(), out dataNascimento))
                {
                    break;
                }

                Console.WriteLine("Data inválida! Tente novamente.\n");
            }

            DateTime hoje = DateTime.Today; // hoje

            // Próximo aniversário (mesmo dia e mês do nascimento, mas no ano atual)
            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

            // Se já passou este ano, pula para o próximo
            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            // diferença
            int diasFaltando = (proximoAniversario - hoje).Days;

            Console.WriteLine($"\nFaltam {diasFaltando} dias para o seu próximo aniversário!");

            // mensagem p/ quando faltar menos de 7 dias
            if (diasFaltando < 7)
            {
                Console.WriteLine("Seu aniversário está quase chegando! Falta menos de 1 semana!");
            }

            Console.WriteLine("\nPressione ENTER para voltar ao menu...");
            Console.ReadLine();
        }
    }
}
