using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclos
{
    internal class Ejercicio10
    {
        static void Main(string[] args)
        {
            int altura = 7;

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= altura; j++)
                {
                    if (i == 1 || i == altura || i + j == altura + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}