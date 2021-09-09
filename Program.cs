using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho02
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        

        public static List<string> GeraLetras()
        {
            List<string> letras = new List<string>();
            letras.Clear();
            for (int i = 0; i < 9; i++)
            {
                Random ram = new Random();
                int num = ram.Next(1, 2 + 1);
                int num3 = ram.Next(1, 3 + 1);
                switch (i)
                {
                    case 1:
                        if (num == 1)
                        {
                            letras.Add("A");
                        }
                        else
                        {
                            letras.Add("D");
                        }
                        break;
                    case 2:
                        if (num == 1)
                        {
                            letras.Add("E");
                        }
                        else
                        {
                            letras.Add("F");
                        }
                        break;
                    case 3:
                        if (num == 1)
                        {
                            letras.Add("B");
                        }
                        else
                        {
                            letras.Add("C");
                        }
                        break;
                    case 4:
                        if (num3 == 1)
                        {
                            letras.Add("G");
                        }
                        else if (num3 == 2)
                        {
                            letras.Add("I");
                        }
                        else
                        {
                            letras.Add("U");
                        }
                        break;
                    case 5:
                        if (num3 == 1)
                        {
                            letras.Add("H");
                        }
                        else if (num3 == 2)
                        {
                            letras.Add("J");
                        }
                        else
                        {
                            letras.Add("V");
                        }
                        break;
                    case 6:
                        if (num == 1)
                        {
                            letras.Add("K");
                        }
                        else
                        {
                            letras.Add("L");
                        }
                        break;
                    case 7:
                        if (num3 == 1)
                        {
                            letras.Add("M");
                        }
                        else if (num3 == 2)
                        {
                            letras.Add("O");
                        }
                        else
                        {
                            letras.Add("Q");
                        }
                        break;
                    case 8:
                        if (num3 == 1)
                        {
                            letras.Add("N");
                        }
                        else if (num3 == 2)
                        {
                            letras.Add("T");
                        }
                        else
                        {
                            letras.Add("P");
                        }
                        break;
                    case 9:
                        if (num3 == 1)
                        {
                            letras.Add("R");
                        }
                        else if (num3 == 2)
                        {
                            letras.Add("S");
                        }
                        else
                        {
                            letras.Add("Z");
                        }
                        break;
                }
            }
            return letras;

        }
    }
}
