using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Gerente : Funcionario
    {

        private const decimal Bonus = 0.2m; // criei uma constante para o bônus de 20%, facilita a manutenção do código

        public override decimal CalcularSalario()
        {
            return SalarioBase * (1 + Bonus);
        }
    }
}
