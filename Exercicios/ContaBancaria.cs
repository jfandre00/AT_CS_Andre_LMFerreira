using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class ContaBancaria
    {
        // Nome do titular -> pode ser acessado livremente
        public string Titular { get; set; }

        // Saldo protegido -> encapsulamento
        private decimal saldo;

        // métodos solicitados
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
                return;
            }

            saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo!");
                return;
            }

            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
                return;
            }

            saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }
    }
}
