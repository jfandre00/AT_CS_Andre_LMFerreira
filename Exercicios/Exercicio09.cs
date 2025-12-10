using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio09
    {

        private const string CAMINHO_ARQUIVO = "estoque.txt";
        // Professor, o arquivo será criado em bin/Debug/net8.0/estoque.txt
        // Fiz essa solução pois não sei onde esse código será executado

        public void Executar()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Controle de Estoque - Exercício 09");
                Console.WriteLine("1 - Inserir Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("0 - Voltar");

                // Usando o validador para garantir que a opção é um número
                opcao = InputUtils.LerInteiro("\nEscolha uma opção: ");

                switch (opcao)
                {
                    case 1:
                        InserirProduto();
                        break;
                    case 2:
                        ListarProdutos();
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

        private void InserirProduto()
        {
            Console.Clear();
            Console.WriteLine("Novo Produto");

            // Coleta de dados com validação
            string nome = InputUtils.LerString("Nome do produto: ");
            int qtd = InputUtils.LerInteiro("Quantidade: ");
            decimal preco = InputUtils.LerDecimal("Preço unitário: ");

            Produto produto = new Produto(nome, qtd, preco); // usando o construtor

            // --- MUDANÇA AQUI: Usando o GerenciadorArquivo ---
            // O código ficou muito mais limpo, sem try/catch complexo aqui
            // pois o Gerenciador já trata erros básicos de IO.

            GerenciadorArquivo.GravarLinha(CAMINHO_ARQUIVO, produto.ParaArquivo());

            Console.WriteLine("\nProduto salvo com sucesso!");
            Pausar();
        }

        private void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Estoque");

            List<string> linhas = GerenciadorArquivo.LerArquivo(CAMINHO_ARQUIVO);

            if (linhas.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            else
            {
                foreach (string linha in linhas)
                {
                    try
                    {
                        Produto p = Produto.DoTextoArquivo(linha);
                        Console.WriteLine(p.ToString());
                    }
                    catch
                    {
                        // Se uma linha estiver corrompida, ignora ela e continua
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


