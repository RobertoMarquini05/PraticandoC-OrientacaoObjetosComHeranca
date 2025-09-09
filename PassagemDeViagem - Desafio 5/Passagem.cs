using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemDeViagem
{
    public class Passagem
    {
        public Guid Id { get; set; }
        public string NomePassageiro { get; set; }
        public string Destino { get; set; }
        public DateTime DateTime { get; set; }

        public Passagem(string nomePassageiro, string destino)
        {
            Id = Guid.NewGuid();
            NomePassageiro = nomePassageiro;
            Destino = destino;
            DateTime = DateTime.Now;
        }

    }
}
