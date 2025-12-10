using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio11
    {
        private const string CAMINHO_ARQUIVO = "contatos.txt";
        // Professor, o arquivo será criado em bin/Debug/net8.0/estoque.txt
        // Fiz essa solução pois não sei onde esse código será executado
        public void Executar()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Gerenciador de Contatos - Exercício 11");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");

                opcao = InputUtils.LerInteiro("\nEscolha uma opção: ");

                switch (opcao)
                {
                    case 1:
                        AdicionarContato();
                        break;
                    case 2:
                        ListarContatos();
                        break;
                    case 3:
                        Console.WriteLine("Encerrando gerenciador de contatos...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Pausar();
                        break;
                }
            } while (opcao != 3); // pedido no enunciado para sair com 3
        }

        private void AdicionarContato()
        {
            Console.Clear();
            Console.WriteLine("--- Novo Contato ---");

            // reaproveitando InputUtils que havia previamente sido criado
            string nome = InputUtils.LerString("Nome: ");
            string telefone = InputUtils.LerString("Telefone (ex: 11 98745-9999): ");
            string email = InputUtils.LerString("Email: ");

            Contato novoContato = new Contato(nome, telefone, email);

            // o gerenciador cuida de abrir, escrever e fechar o arquivo
            GerenciadorArquivo.GravarLinha(CAMINHO_ARQUIVO, novoContato.ParaArquivo());

            Console.WriteLine("\nContato cadastrado com sucesso!");
            Pausar();
        }

        private void ListarContatos()
        {
            Console.Clear();
            Console.WriteLine("--- Contatos Cadastrados ---");

            // leitura de todas as linhas do arquivo
            List<string> linhas = GerenciadorArquivo.LerArquivo(CAMINHO_ARQUIVO);

            if (linhas.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
            }
            else
            {
                foreach (string linha in linhas)
                {
                    try
                    {
                        // para cada linha, tenta criar um contato
                        Contato c = Contato.DoTextoArquivo(linha);
                        Console.WriteLine(c.ToString());
                    }
                    catch
                    {
                        // Ignora linhas mal formatadas
                    }
                }
            }
            Pausar();
        }

        private void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        }
    }
}
