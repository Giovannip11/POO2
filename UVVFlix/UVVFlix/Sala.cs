using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFlix
{
    internal class Sala
    {
        public int idSala {  get; set; }
        public int numAssentos {  get; set; }
        public String tipoTela {  get; set; }
        public String localizacao { get; set; }
        public List<Sessao> s = new List<Sessao>();

        public Sala(int IdSala,int NumAssentos,String TipoTela,String Localizacao)
        {
            idSala = IdSala;
            numAssentos = NumAssentos;
            tipoTela = TipoTela;   
            localizacao = Localizacao;
           
        }

        public void addSessao()
        {
            s.Add(new Sessao());
        }
        public void removerSessao() 
        {
            s.Remove(new Sessao()); 
        }
    }
}
