using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque___Desafio_7
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }    
        private int QuantidadeEstoque {  get; set; }
        public DateTime CreatedAt { get; set; }

        public Produto(string nome, int quantidadeEstoque)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            QuantidadeEstoque = quantidadeEstoque;
            CreatedAt = DateTime.Now;
        }

        public void Retirar(int quantidade)
        {
            if (QuantidadeEstoque > quantidade)
            {
                QuantidadeEstoque = QuantidadeEstoque - quantidade;
            }
            else
            {
                Console.WriteLine($"Erro: Estoque insuficiente para retirada de {quantidade} unidade(s).");
            }
        }

        public void ExibirEstoque()
        {
            Console.WriteLine($"Estoque: {QuantidadeEstoque}");
        }
    }
}
