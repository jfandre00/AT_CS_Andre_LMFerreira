using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio07

    {
        public void Executar()
        {
            Console.WriteLine("\nBanco Digital c/ Encapsulamento - Exercício 07\n");

            ContaBancaria conta = new ContaBancaria();

            conta.Titular = "André LMF"; // acessei livremente
            
            Console.WriteLine($"Titular: {conta.Titular}\n");

            // Simulando operações
            conta.Depositar(500m);
            conta.ExibirSaldo();

            Console.WriteLine("\nTentativa de saque: R$ 700,00");
            conta.Sacar(700m); // saldo insuficiente

            conta.Sacar(200m); // saque válido
            conta.ExibirSaldo();

            Console.WriteLine("\nPressione ENTER para voltar ao menu...");
            Console.ReadLine();
        }
    }
}
