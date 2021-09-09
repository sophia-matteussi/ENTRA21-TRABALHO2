using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trabalho02.Controlller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho02.Controlller.Tests
{
    [TestClass()]
    public class TabuleiroControllerTests
    {
        [TestMethod()]
        public void ConfereLetraRepetidaTest()
        {
            Assert.IsFalse(TabuleiroController.ConfereLetraRepetida("aabc"));
            Assert.IsFalse(TabuleiroController.ConfereLetraRepetida("aabbc"));
            Assert.IsFalse(TabuleiroController.ConfereLetraRepetida("aabbolçiaerhefdlijvhawccc"));
            Assert.IsFalse(TabuleiroController.ConfereLetraRepetida("abca"));
            Assert.IsTrue(TabuleiroController.ConfereLetraRepetida("abc"));
            //Assert.Fail();
        }

        [TestMethod()]
        public void ExisteLetraTest()
        {
            List<List<char>> matriz = TabuleiroController.Matriz();
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(3, matriz[i].Count);
                for (int f = 0; f < 3; f++)
                {
                    System.Console.Write(matriz[i][f] + " ");
                }
                System.Console.WriteLine("");
            }
            string letra;
            letra = TabuleiroController.Matriz()[0][0].ToString();
            Console.WriteLine(letra);
            Assert.IsTrue(TabuleiroController.ExisteLetras(letra));
            letra = TabuleiroController.Matriz()[1][1].ToString();
            Console.WriteLine(letra);
            Assert.IsTrue(TabuleiroController.ExisteLetras(letra));
            letra = TabuleiroController.Matriz()[2][2].ToString();
            Console.WriteLine(letra);
            Assert.IsTrue(TabuleiroController.ExisteLetras(letra));

            Assert.IsFalse(TabuleiroController.ExisteLetras("çê"));
        }

        [TestMethod()]
        public void MapeamentPalavraTest()
        {
            List<List<char>> matriz = TabuleiroController.Matriz();
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(3, matriz[i].Count);
                for (int f = 0; f < 3; f++)
                {
                    System.Console.Write(matriz[i][f] + " ");
                }
                System.Console.WriteLine("");
            }

            string palavra = matriz[0][0].ToString() + matriz[1][1] + matriz[2][2];
            Console.WriteLine(palavra);
            Assert.IsTrue(TabuleiroController.MapeamentoPalavra(palavra));

            palavra = matriz[0][0].ToString() + matriz[2][2] + matriz[0][2];
            Console.WriteLine(palavra);
            Assert.IsFalse(TabuleiroController.MapeamentoPalavra(palavra));
        }

        [TestMethod()]

        public void ConferePalavraTest()
        {
            List<List<char>> matriz = TabuleiroController.Matriz();
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(3, matriz[i].Count);
                for (int f = 0; f < 3; f++)
                {
                    System.Console.Write(matriz[i][f] + " ");
                }
                System.Console.WriteLine("");
            }
            string palavra = matriz[0][0].ToString() + matriz[1][1] + matriz[2][2];
            int retorno = TabuleiroController.ConferePalavra(palavra);
            Assert.AreEqual(1 , retorno);
            Console.WriteLine("A palavra " + palavra + " retornou: " + retorno);

            palavra = "ç";
            retorno = TabuleiroController.ConferePalavra(palavra);
            Assert.AreEqual(-1, retorno);
            Console.WriteLine("A palavra " + palavra + " retornou: " + retorno);

            palavra = matriz[0][0].ToString() + matriz[0][0] + matriz[2][2];
            retorno = TabuleiroController.ConferePalavra(palavra);
            Assert.AreEqual(-2, retorno);
            Console.WriteLine("A palavra " + palavra + " retornou: " + retorno);

            palavra = matriz[0][0].ToString() + matriz[1][1] + matriz[2][2];
            retorno = TabuleiroController.ConferePalavra(palavra);
            Assert.AreEqual(-3, retorno);
            Console.WriteLine("A palavra " + palavra + " retornou: " + retorno);

            palavra = matriz[0][0].ToString() + matriz[2][2];
            retorno = TabuleiroController.ConferePalavra(palavra);
            Assert.AreEqual(-4, retorno);
            Console.WriteLine("A palavra " + palavra + " retornou: " + retorno);

        }
    }
}