using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho02.Model;

namespace Trabalho02.Controlller
{
    static public class TabuleiroController
    {
        public static Tabuleiro tabuleiro = new Tabuleiro(); //Inicia o objeto Tabuleiro, pode ser usado em todo o Controller
        public static List<List<char>> Matriz() //Retorna matriz para a view;
        {
            return tabuleiro.Matriz;
        }

        public static List<string> Palavras() //Retorna a lista de Palavras para a view;
        {
            return tabuleiro.Palavras;
        }

        public static bool ConfereLetraRepetida(string palavra) //Função que confere se há alguma letra repetida na palavra inserida pelo jogador;
        {
            //Compara as letras da palavra;
            for (int i = 0; i < palavra.Length; i++)
            {
                for (int j = i + 1; j < palavra.Length; j++)
                {
                    if (palavra[i] == palavra[j])
                    {
                        return false; //Retorna false se houver letra repetida;
                    }
                }
            }
            return true; //Retorna true se a palavra estiver sem letras repetidas;
        }

        public static bool ConferePalavraRepetida(string palavra) //Função que confere se a palavra inserida pelo jogador já está na lista de palavras inseridas;
        {
            for (int i = 0; i < tabuleiro.Palavras.Count; i++)
            {
                if (tabuleiro.Palavras[i] == palavra)
                {
                    return false; //Retorna false se houver palavra repetida;
                }
            }
            return true; //Retorna true se a palavra não estiver repetida;
        }

        public static bool ExisteLetras(string palavra) //Função que confere se as letras da palavra realmente existem na matriz do tabuleiro;
        {
            foreach (char letra in palavra)
            {
                bool letraExiste = false;
                for (int i = 0; i < tabuleiro.Matriz.Count; i++) // passa por cada letra da matriz e checa se a letra da palavra está lá;
                {
                    for (int j = 0; j < tabuleiro.Matriz[i].Count; j++)
                    {
                        if (tabuleiro.Matriz[i][j] == letra)
                        {
                            letraExiste = true;
                        }
                    }
                }
                if (!letraExiste) //confere se letraExiste é true ou false, se for false (não existe), retorna false;
                {
                    return false;
                }
            }
            return true; //Retorna true caso todas as letras da palavra existam na matriz;
        }

        public static bool MapeamentoPalavra(string palavra) //Função que irá conferir se as letras estão no raio uma das outras => é adjacente? => Faz mapeamento;
        {
            int x = -1; //linha;
            int y = -1; //coluna;

            for (int l = 0; l < palavra.Length - 1; l++) //Irá retornar o índice (localização) de cada letra;
            {
                bool adjacente = false;
                char letra = palavra[l];
                for (int i = 0; i < tabuleiro.Matriz.Count; i++)
                {
                    for (int j = 0; j < tabuleiro.Matriz[i].Count; j++)
                    {
                        if (tabuleiro.Matriz[i][j] == letra)
                        {
                            x = i;
                            y = j;
                        }
                    }
                }

                for (int i = -1; i <= 1; i++) //Confere os espaços ao redor da letra atual do loop (incrementando o índice i)
                {
                    for (int j = -1; j <= 1; j++) //Confere os espaços ao redor da letra atual do loop (incrementando o índice j)
                    {
                        if (i != 0 || j != 0) // somar 0 no X e Y seria a letra atual;
                        {
                            if (((x + i) > -1 && (x + i) < 3) && ((y + j) > -1 && (y + j) < 3)) //Não existe -1 na matriz e ela vai apenas até 2 (deve ser menor que 3); => Confere
                            {
                                if (palavra[l + 1] == tabuleiro.Matriz[x + i][y + j]) //Checa se a letra ao redor é igual a próxima letra da palavra;
                                {
                                    adjacente = true; //Se for adjacente, retorna true;
                                }
                            }
                        }
                    }
                }
                if (!adjacente) //Confere se for adjacente, retorna false se não for;
                {
                    return false;
                }
            }
            return true;
        }

        public static int ContaPontuacao(string palavra) //Função que faz a contagem da pontuação do jogador, caso a palavra esteja correta;
        {
            if ((palavra.Length % 2) == 0) //Se o numero de caracteres da palavra for par, divide por 2 e retorna essa pontuação;
            {
                return palavra.Length / 2;
            }
            else
            {
                return (palavra.Length - 1) / 2; //Se o numero de caracteres da palavra for ímpar, subtrai 1 e divide o resto por 2 e retorna essa pontuação;
            }
        }

        /// <summary>
        /// Legenda de retornos:
        /// -1 = Letra não existe;
        /// -2 = Letra Repetida;
        /// -3 = Palavra repetida;
        /// -4 = Palavra inválida;
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        public static int ConferePalavra(string palavra) //Chama todas as funções para conferir a palavra inserida pelo user;
        {
            bool confere; //Irá conferir o retorno de cada função, caso verdadeiro, chama a próxima, caso não, retorna um número conforme legenda;

            confere = ExisteLetras(palavra); //Função que confere se a letra realmente existe na matriz de letras;
            if (confere)
            {
                confere = ConfereLetraRepetida(palavra); //Função que confere se há alguma letra repetida na palavra inserida pelo jogador;
                if (confere)
                {
                    confere = ConferePalavraRepetida(palavra); //Função que confere se a palavra inserida pelo jogador já está na lista de palavras inseridas;
                    if (confere)
                    {
                        confere = MapeamentoPalavra(palavra); //Função que irá conferir se as letras estão no raio uma das outras => é adjacente? => Faz mapeamento;
                        if (confere) //Se der true, todos os anteriores deram também, assim irá:
                        {
                            tabuleiro.Palavras.Add(palavra); //adiciona palavra para persistência;
                            return ContaPontuacao(palavra); //retornará apenas a pontuação do jogador;
                        }
                        else
                        {
                            return -4;
                        }
                    }
                    else
                    {
                        return -3;
                    }
                }
                else
                {
                    return -2;
                }
            }
            else
            {
                return -1;
            }
        }

        public static List<List<char>> BotaoNovo() //Gera novo caça-palavras;
        {
            tabuleiro = new Tabuleiro();
            return tabuleiro.Matriz;
        }
    }
}
