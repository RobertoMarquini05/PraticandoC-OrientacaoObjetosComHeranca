using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoAcessoFilme___Desafio_6
{
    public class Filme
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public int ClassificacaoEtaria { get; set; }
        public DateTime CreatedAt { get; set; }

        public Filme(string titulo, int classificacaoEtaria)
        {
            Titulo = titulo;
            ClassificacaoEtaria = classificacaoEtaria;
        }

        public bool PodeAssistir(int idadeUsuario)
        {
            return idadeUsuario >= ClassificacaoEtaria ? true : false;
        }

        public void ExibirResultado(int idadeUsuario)
        {
            string resultado = PodeAssistir(idadeUsuario) ? $"Usuário com {idadeUsuario} anos pode assistir ao filme {Titulo}" : $"Usuário com {idadeUsuario} anos não pode assistir ao filme {Titulo}";
            Console.WriteLine(resultado);
        }
    }
}
