using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoOrientacaoAObjetosComClasses
{
    public class Livro
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }   
        public string Autor {  get; set; }
        public DateTime CreatedAt { get; set; }

        public Livro(string nome, string autor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Autor = autor;
            CreatedAt = DateTime.Now;
        }
    }
}
