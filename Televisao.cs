using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
     String Marca { get; set; }
        int Tamanho { get; set; }
        String Tipo { get; set; }

        public Televisao(String marca, int tamanho, String tipo)
        {
            Marca = marca;
            Tamanho = tamanho;
            Tipo = tipo;
        }
        public void ligar(){
            Console.Write("ligando...");
        }
        public void desligar(){
            Console.Write("Desligando...");
        }
        public void mudarDeCanal(){
            Console.Write("Mudando de canal...");
        }
    }
}

