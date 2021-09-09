using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Trabalho02;
using Trabalho02.Model;

namespace Trabalho02.Tests
{
    [TestClass()]
    public class TabuleiroTests
    {
        [TestMethod()]
        public void TabuleiroTest()
        {
            Tabuleiro tabuleiro = new Tabuleiro();

            Assert.AreEqual(3, tabuleiro.Matriz.Count);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(3, tabuleiro.Matriz[i].Count);
                for (int f = 0; f < 3; f++)
                {
                    System.Console.Write(tabuleiro.Matriz[i][f] + " ");
                }
                System.Console.WriteLine("");
            }
        }
    }
}
