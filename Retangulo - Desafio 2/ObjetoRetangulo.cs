using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    public class ObjetoRetangulo
    {
        public Guid Id { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public DateTime CreatedAt { get; set; }

        public ObjetoRetangulo(int altura, int largura)
        {
            Id = Guid.NewGuid();
            Altura = altura;
            Largura = largura;
            CreatedAt = new DateTime();
        }

        public string CalcularArea()
        {
            int area = Altura * Largura;
            return $"Área do Retângulo: {area}";
        }
    }
}
