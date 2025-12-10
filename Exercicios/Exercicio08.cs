using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio08
    {
        public void Executar()
        {
            Console.WriteLine("\nCadastro de Funcionários (Herança) - Exercicio 08\n");

            // Funcionário comum
            Funcionario funcionario = new Funcionario
            {
                Nome = "Andre Ferreira",
                Cargo = "Assistente Administrativo",
                SalarioBase = 3000m
            };

            // Gerente
            Gerente gerente = new Gerente
            {
                Nome = "Andre Montini",
                Cargo = "Gerente de Projetos",
                SalarioBase = 3000m
            };

            Console.WriteLine("Funcionário:");
            Console.WriteLine(funcionario.ToString());

            Console.WriteLine("Gerente:");
            Console.WriteLine(gerente.ToString()); // Funciona corretamente pois Gerente herda de Funcionario

            Console.WriteLine("Pressione ENTER para voltar ao menu...");
            Console.ReadLine();
        }
    }
}
