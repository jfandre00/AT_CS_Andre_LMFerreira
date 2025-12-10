using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio12
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
                Console.WriteLine("Contatos com Polimorfismo - Exercício 12");
                Console.WriteLine("1 - Cadastrar Contato");
                Console.WriteLine("2 - Visualizar Contatos (Escolher Formato)");
                Console.WriteLine("0 - Voltar");

                opcao = InputUtils.LerInteiro("\nEscolha uma opção: ");

                switch (opcao)
                {
                    case 1:
                        CadastrarContato();
                        break;
                    case 2:
                        ListarContatos();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Pausar();
                        break;
                }
            } while (opcao != 0);
        }

        // igual ao exercício 11 (poderia ter criado uma classe base para evitar repetição) 
        private void CadastrarContato()
        {
            Console.Clear();
            Console.WriteLine("Novo Contato");
            string nome = InputUtils.LerString("Nome: ");
            string telefone = InputUtils.LerString("Telefone: ");
            string email = InputUtils.LerString("Email: ");

            Contato novo = new Contato(nome, telefone, email);

            GerenciadorArquivo.GravarLinha(CAMINHO_ARQUIVO, novo.ParaArquivo());

            Console.WriteLine("Salvo com sucesso!");
            Pausar();
        }

        // Listagem com polimorfismo
        private void ListarContatos()
        {
            Console.Clear();
            // 1 - ler os dados do arquivo para a memória
            List<Contato> listaDeContatos = LerArquivoParaLista();

            if (listaDeContatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato encontrado no arquivo.");
                Pausar();
                return;
            }

            // 2 - perguntamos como o usuário quer ver
            Console.WriteLine($"Foram encontrados {listaDeContatos.Count} contatos.");
            Console.WriteLine("\nEscolha o formato de exibição:");
            Console.WriteLine("1 - Markdown (Web)");
            Console.WriteLine("2 - Tabela (Organizado)");
            Console.WriteLine("3 - Texto Puro (Simples)");

            int escolha = InputUtils.LerInteiro("Opção: ");

            // 3 - POLIMORFISMO: A variável é do tipo mãe, mas recebe um objeto filho
            ContatoFormatter formatter;

            switch (escolha)
            {
                case 1:
                    formatter = new MarkdownFormatter();
                    break;
                case 2:
                    formatter = new TabelaFormatter();
                    break;
                case 3:
                    formatter = new RawTextFormatter();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Usando Texto Puro como padrão.");
                    formatter = new RawTextFormatter();
                    break;
            }

            Console.Clear();
            // 4 - chamar o método
            formatter.ExibirContatos(listaDeContatos);

            Pausar();
        }

        // método auxiliar p/ ler o arquivo e devolver uma Lista de Objetos
        private List<Contato> LerArquivoParaLista()
        {
            List<Contato> listaObjs = new List<Contato>();

            // O GerenciadorArquivo já trata se o arquivo existe ou não
            List<string> linhasTexto = GerenciadorArquivo.LerArquivo(CAMINHO_ARQUIVO);

            foreach (string linha in linhasTexto)
            {
                try
                {
                    // Converte a linha de texto em Objeto Contato
                    listaObjs.Add(Contato.DoTextoArquivo(linha));
                }
                catch
                {
                    // Se uma linha estiver corrompida, ignora ela
                }
            }

            return listaObjs;
        }

        private void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
