using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne.Assignment_1c
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(5, 5); 



            for (int i = 0; i < 10; i++)
            {

                Calculator:
                Console.WriteLine("***My Calculator***");
                Console.WriteLine("Press \n1) for Addition \n2) for Subtraction \n3) for Multiplication \n4) for Division");
                string input = Console.ReadLine();

                

                if (input == "1")
                {
                    Console.Clear();
                    Math.Addition();

                }
                else if (input == "2")
                {
                    Console.Clear();
                    Math.Subtraction();

                }
                else if (input == "3")
                {
                    Console.Clear();
                    Math.Multiplication();
                }
                else if (input == "4")
                {
                    Console.Clear();
                    Math.Division();
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again!!");
                    goto Calculator;
                }

            }
        }
    }

}
