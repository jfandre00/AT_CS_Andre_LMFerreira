using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nCargo: {Cargo}\nSalário: R$ {CalcularSalario():F2}\n";
        }
    }
}
