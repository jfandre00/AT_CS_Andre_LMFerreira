using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_CS_Andre_LMFerreira.Exercicios
{
    internal class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, int quantidade, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        // de objeto para texto (Para Gravar)
        public string ParaArquivo()
        {
            return $"{Nome},{Quantidade},{Preco.ToString(CultureInfo.InvariantCulture)}";
        }

        // para exibição no console
        public override string ToString()
        {
            return $"Produto: {Nome} | Quantidade: {Quantidade} | Preço: {Preco:C}";
        }

        // de texto para objeto (Para Ler)
        public static Produto DoTextoArquivo(string linha)
        {
            string[] dados = linha.Split(',');

            // dados[0] = Nome
            // dados[1] = Quantidade
            // dados[2] = Preco

            // Convertendo as strings de volta para int e decimal
            return new Produto(
                dados[0],
                int.Parse(dados[1]),
                decimal.Parse(dados[2], CultureInfo.InvariantCulture)
            );
        }


    }
}
