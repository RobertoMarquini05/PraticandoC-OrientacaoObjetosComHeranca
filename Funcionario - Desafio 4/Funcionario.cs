using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario___Desafio_4
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public DateTime CreatedAt { get; set; }
        public Funcionario(string nome, string cargo) 
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Cargo = cargo;
            CreatedAt = DateTime.Now;
        }

        public string Promover(string novoCargo)
        {
            if (novoCargo != Cargo)
            {
                Cargo = novoCargo;
                return $"Promoção realizada com sucesso!";
            }
            else
                return "Erro: O novo cargo deve ser diferente do cargo atual.";
        }
    }
}
