using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] intArray2 = intArray;
            int[] intArray3 = intArray;

            int[,] tDArray = new int[10, 10];

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    tDArray[i, j] = i * j;
                }
              
            }

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}\t", tDArray[i, j]);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}
