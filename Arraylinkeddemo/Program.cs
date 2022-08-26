using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylinkeddemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 100, 200, 300 }, { 1000, 2000, 3000 } };
            int len  = arr.GetLength(0);
            Console.WriteLine(len);

            for(int i = 0 ; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(0);j++)
                {
                    Console.Write(" {0} ", arr[i, j]);

                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
