using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int xSize = 10;
            int ySize = 10;
            int[,] matrix = new int[xSize, ySize];

            for(int x = 0; x < xSize; x++)
            {
                for(int y = 0; y < ySize; y++)
                {
                    double temp = Math.Pow(x, y);
                    int convert = Convert.ToInt32(temp);
                    matrix[x, y] = convert;
                }
            }

            System.Console.WriteLine("Array initialized, now printing values");

            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    int temp = matrix[x,y];
                    System.Console.Write("[" + temp + "]" + " ");
                }
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
}
