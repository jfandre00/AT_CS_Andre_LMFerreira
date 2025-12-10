using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Aluno
    {
        // atributos
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public double Media { get; set; }

        // métodos solicitado
        public void ExibirDados()
        {
            Console.WriteLine("\nDados do Aluno");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Média: {Media}");
            Console.WriteLine($"Situação: {VerificarAprovacao()}");
        }

        public string VerificarAprovacao()
        {
            return Media >= 7 ? "Aprovado" : "Reprovado";
        }
    }
}
