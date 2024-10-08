using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFlix
{
    internal class Sessao
    {
        public Boolean  statusSessao {  get; set; }
        public String horario {  get; set; }
        public Sala sala { get; set; }
        public List<Filme>filmes=new List<Filme>();

    }
}
