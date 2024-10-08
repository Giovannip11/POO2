using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVVFlix
{
    internal class Filme
    {
        int idFilme {  get; set; }
        String titulo {  get; set; }
        long duracao { get; set; }
        String genero {  get; set; }
        public List<Ator> atores= new List<Ator>();
        public Sessao s {  get; set; }

    }
    public Filme(int idFilme, string titulo, long duracao, string genero,  Sessao sessao)
    {
        IdFilme = idFilme;
        Titulo = titulo;
        Duracao = duracao;
        Genero = genero;
        Sessao = sessao;
    }




}
