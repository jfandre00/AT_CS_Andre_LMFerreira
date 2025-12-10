using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    // Classe Base (Mãe)
    public abstract class ContatoFormatter
    {
        // Método abstrato que obriga os filhos a implementarem sua própria versão mas com a mesma assinatura
        public abstract void ExibirContatos(List<Contato> contatos);
    }

    // Filho 1 - Texto Puro como no Exercicio 11
    public class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("\n--- Formato: Texto Puro ---");
            foreach (var c in contatos)
            {
                // utiliza o ToString() de Contato
                Console.WriteLine(c.ToString());
            }
        }
    }

    // Filho 2 - Formato Markdown
    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("\n--- Formato: Markdown ---");
            Console.WriteLine("## Lista de Contatos");

            foreach (var c in contatos)
            {
                Console.WriteLine($"- **Nome:** {c.Nome}");
                Console.WriteLine($"  - 📞 Telefone: {c.Telefone}");
                Console.WriteLine($"  - 📧 Email: {c.Email}");
                Console.WriteLine(); // Linha em branco p/ separar
            }
        }
    }

    // Filho 3 - Formato Tabela no Console
    public class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("\n--- Formato: Tabela ---");

            // linha superior/inferior da tabela
            string linhaSeparadora = new string('-', 75);

            Console.WriteLine(linhaSeparadora);

            // abaixo os cabeçalhos que serão alinhados com formatação
            // encontrei essa formatação ao pesquisar "C# string format table" no stackoverflow
            Console.WriteLine("| {0,-20} | {1,-20} | {2,-25} |", "Nome", "Telefone", "Email");
            
            Console.WriteLine(linhaSeparadora);

            foreach (var c in contatos)
            {
                // Caso a string seja muito grande, corta e add ... para não quebrar a tabela
                string nome = c.Nome.Length > 17 ? c.Nome.Substring(0, 17) + "..." : c.Nome;
                string email = c.Email.Length > 22 ? c.Email.Substring(0, 22) + "..." : c.Email;

                Console.WriteLine("| {0,-20} | {1,-20} | {2,-25} |", nome, c.Telefone, email);
            }
            Console.WriteLine(linhaSeparadora);
        }
    }
}
