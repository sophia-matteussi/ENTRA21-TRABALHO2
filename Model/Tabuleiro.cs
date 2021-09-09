using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho02.Model
{
    public class Tabuleiro
    {
        public List<string> Palavras { get; set; } //Lista persistente (enquanto tabuleiro existe) das palavras inseridas;
        public List<List<char>> Matriz  { get; } //Guarda a Matriz do tabuleiro;

        //Matriz com todas as letras possiveis para o caça-palavras;
        private readonly char[][] Letras =
            {
                new char[] {'A','D'},
                new char[] {'E','F'},
                new char[] {'B','C'},
                new char[] {'G','I','U'},
                new char[] {'H','J','V'},
                new char[] {'K','L'},
                new char[] {'M','O','Q'},
                new char[] {'N','T','P'},
                new char[] {'R','S','Z'}
            };      
        
        public Tabuleiro() //Função construtor que gerará a matriz aleatória, a partir de outras funções;
        {
            Palavras = new List<string>();
            Matriz = new List<List<char>>();
            for (int i = 0; i < 3; i++)
            {
                List<char> linha = new List<char>();
                for (int f = 0; f < 3; f++)
                {
                    linha.Add(RandomChar(Letras[3 * i + f])); //Para passar pelos 9 índices da matriz de letras, e em cada loop do for(i), pulará as já utilizadas (que estão nas linhas anteriores);
                }
                Matriz.Add(linha);
            }
        }
      
        private char RandomChar(char[] chars) //Faz o random de cada indíce (A ou D...)
        {
            System.Threading.Thread.Sleep(100); //Pausa na thread => precisa para o aleatório funcionar;
            Random ran = new Random();
            int index = ran.Next(chars.Length);
            return chars[index];
        }
    }
}
