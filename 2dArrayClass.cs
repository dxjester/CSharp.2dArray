using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDimArray
{
    class Program
    {

        //Constructor class
        class twoDim
        {
            private int colSize;
            private int rowSize;
            string arrayName;
            int[][] numArray = new int[0][0];
        }//end Constructor

        //Prompt end user for column and row size of array
        public void initialize()
        {

            Console.Write("\nHow many columns are in your array?");
            colSize = int.Parse(Console.ReadLine());

            Console.Write("\nHow many rows are in your array?");
            rowSize = int.Parse(Console.ReadLine());

            Console.Write("\nWhat would you like to name your array?");
            arrayName = char.Parse(Console.ReadLine());

            numArray[colSize][rowSize];
        }//end initialize() method

        //Method to print the two dimensional array and total array count
        public void printArray()
        {
            int arrayCount = 0;

            for(int x = 0; x<10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    Console.Write("[" + arrayCount + "] ");
                    arrayCount++;
                }
                Console.WriteLine("\n");

            }//end for loop

        }//end printArray() function

        static void Main(string[] args)
        {
            twoDim test = new twoDim();
            test.initialize()
        }

    }//end Program class

}//end twoDimArray namesapce
