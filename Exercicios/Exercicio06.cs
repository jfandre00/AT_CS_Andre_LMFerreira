using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio06
    {
        public void Executar()
        {
            Console.WriteLine("\nCadastro de Aluno - Exercício 06\n");

            // Criando um objeto aluno com seus dados
            Aluno aluno = new Aluno
            {
                Nome = "André LMF",
                Matricula = "2025001",
                Curso = "Análise e Desenvolvimento de Sistemas",
                Media = 8.5
            };

            aluno.ExibirDados();

            Console.WriteLine("\nPressione ENTER para voltar ao menu...");
            Console.ReadLine();
        }
    }
}
