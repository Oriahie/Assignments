using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne.Assignment_1c
{
    public class Math
    {
        private int input1, input2;

        public Math(int x, int y)
        {
            input1 = x;
            input2 = y;    

        }

        
        public static void Addition()
        {
            Console.Write("Insert first number : ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("Insert second number : ");
            int input2 = int.Parse(Console.ReadLine());
            int result = input1 + input2;
            Console.WriteLine($"The answer is : {result}");
            Console.ReadLine();
            Console.Clear();

        }

        public static void Subtraction()
        {

            Console.Write("Insert first number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insert second number : ");
            int y = int.Parse(Console.ReadLine());
            int result = x - y;
            Console.WriteLine($"The answer is : {result}");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Multiplication()
        {

            Console.Write("Insert first number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insert second number : ");
            int y = int.Parse(Console.ReadLine());
            int result = x * y;
            Console.WriteLine($"The answer is : {result}");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Division()
        {

            Console.Write("Insert first number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insert second number : ");
            int y = int.Parse(Console.ReadLine());
            int result = x / y;
            Console.WriteLine($"The answer is : {result}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
