using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSecreto = 10;
            String nome;
            int chute;
            int numTentativas = 0;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu chute ai:");
            chute = int.Parse(Console.ReadLine());

            while (numTentativas < 16)
            {
                numTentativas++;

                if (numTentativas >= 3 && numTentativas <= 5) { Console.WriteLine("Dica 1: O número está entre 1 a 1000"); }
                else if (numTentativas >= 8 && numTentativas <= 10) { Console.WriteLine("Dica 2: O número está entre 1 a 100"); }
                else if (numTentativas >= 13) { Console.WriteLine("Dica 3: O número está entre 1 a 10"); }

                Console.WriteLine("Digite seu chute");
                chute = int.Parse(Console.ReadLine());

                if (chute == numSecreto) { Console.WriteLine("Parabéns voce acertou"); break; }
                else
                {
                    Console.WriteLine("Chute errado");

                }
                if (numTentativas == 16)
                {
                    Console.WriteLine("Fim de jogo voce atingiu o limite máximo de tentativas");
                }
            }
        }
    }
}
    
