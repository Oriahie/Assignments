﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    public class Math
    {
        public void Addition()
        {
            Console.Write("Insert first number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insert second number : ");
            int y = int.Parse(Console.ReadLine());
            float result = x + y;
            Console.WriteLine($"The answer is : {result}");
            Console.ReadLine();
            Console.Clear();

        }

        public void Subtraction()
        {

            Console.Write("Insert first number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insert second number : ");
            int y = int.Parse(Console.ReadLine());
            float result = x - y;
            Console.WriteLine($"The answer is : {result}");
            Console.ReadLine();
            Console.Clear();
        }

        public void Multiplication()
        {

            Console.Write("Insert first number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insert second number : ");
            int y = int.Parse(Console.ReadLine());
            float result = x * y;
            Console.WriteLine($"The answer is : {result}");
            Console.ReadLine();
            Console.Clear();
        }

        public void Division()
        {

            Console.Write("Insert first number : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insert second number : ");
            int y = int.Parse(Console.ReadLine());
            float result = x / y;
            Console.WriteLine($"The answer is : {result}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
