using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    public class Contato // resolve o problema do Erro CS0051 no Formatters.cs
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        // de objeto para texto - para salvar no arquivo
        public string ParaArquivo()
        {
            return $"{Nome},{Telefone},{Email}";
        }

        // de texto para objeto - para ler do arquivo
        public static Contato DoTextoArquivo(string linha)
        {
            string[] dados = linha.Split(',');
            // Retorna um novo contato com os dados da linha
            return new Contato(dados[0], dados[1], dados[2]);
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Telefone: {Telefone} | Email: {Email}";
        }
    }
}
