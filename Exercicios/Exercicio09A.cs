namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Exercicio09A
    {
        
        // array para armazenar até 5 produtos
        private Produto[] estoque = new Produto[5];

        private int quantidadeCadastrada = 0;

        public void Executar()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Estoque em Memória - Exercício 09 (PARTE A)");
                Console.WriteLine($"Capacidade utilizada: {quantidadeCadastrada}/5");
                Console.WriteLine("1 - Inserir Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("0 - Sair");

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

            if (quantidadeCadastrada >= 5)
            {
                Console.WriteLine("Erro: Limite de produtos atingido! (Máximo 5)");
                Pausar();
                return;
            }

            // Coleta de dados usando nosso Utilitário
            string nome = InputUtils.LerString("Nome do produto: ");
            int qtd = InputUtils.LerInteiro("Quantidade em estoque: ");
            decimal preco = InputUtils.LerDecimal("Preço unitário: ");

            // Cria o objeto produto
            Produto novoProduto = new Produto(nome, qtd, preco);

            // Armazena no array na posição atual e incrementa o contador
            estoque[quantidadeCadastrada] = novoProduto;
            quantidadeCadastrada++;

            Console.WriteLine("\nProduto cadastrado com sucesso na memória!");
            Pausar();
        }

        private void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Estoque (Array)");

            if (quantidadeCadastrada == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            else
            {
                for (int i = 0; i < quantidadeCadastrada; i++)
                {
                    // Usando o ToString() da classe Produto
                    Console.WriteLine(estoque[i].ToString());
                }
            }
            Pausar();
        }

        private void Pausar() // fazendo essa pausa por método agora
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}