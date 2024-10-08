using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFlix
{
    internal class Ator
    {
        public int idAtor { get; set; }
        public String nome { get; set; }
        public String papel { get; set; }
        public List<Filme> filmes = new List<Filme>();

        public Ator(int IdAtor, String Nome, String Papel)
        {
            idAtor = IdAtor;
            nome = Nome;
            papel = Papel;
        }
        public void addFilme()
        {
            filmes.Add(new Filme());
        }
            
                
    }
}
