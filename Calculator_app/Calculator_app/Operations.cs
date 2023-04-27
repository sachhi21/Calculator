using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_app
{
    class Calculator
    {
        /*public void Addition()
        {
            int result = 0;
            Console.WriteLine("Enter no. of Numbers to be added");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers you want to add:");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Number {0}", i + 1);
                int b = Convert.ToInt32(Console.ReadLine());
                result = result + b;
            }
            Console.WriteLine("Sum: {0}", result);
        }
        public void Subtraction()
        {
            int result = 0;
            Console.WriteLine("Enter numbers to be subtracted:");
            Console.WriteLine("Number 1:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number 2:");
            int input2 = Convert.ToInt32(Console.ReadLine());

            result = input1 - input2;

            Console.WriteLine("After Subtraction: {0}", result);
        }*/
        public void Addition()
        {
            List<int> subList = new List<int>();
            Console.WriteLine("Enter no. of Numbers to be added");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers you want to add:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Number {0}", i + 1);
                subList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Sum: {0}", subList.Sum());
        }
        public void Subtraction()
        {
            List<int> subList = new List<int>();
            Console.WriteLine("Enter no. of Numbers to be subtracted");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            Console.WriteLine("Enter the numbers you want to subtract:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Number {0}", i + 1);
                subList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var item in subList)
            {
                if (result == 0)
                {
                    result = item;
                }
                else
                {
                    result -= item;
                }
            }
            Console.WriteLine("After Subtraction: {0}", result);
        }
        public void Multiplication()
        {
            int result = 1;
            Console.WriteLine("Enter no. of Numbers to be multiplied");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers you want to multiply:");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Number {0}", i + 1);
                int b = Convert.ToInt32(Console.ReadLine());
                result = result * b;
            }
            Console.WriteLine("After multiplication: {0}", result);
        }
        public void Division()
        {
            float result;
            Console.WriteLine("Enter numbers to be divided:");
            Console.WriteLine("Number 1:");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number 2:");
            double input2 = Convert.ToDouble(Console.ReadLine());

            result = (float)(input1 / input2);

            Console.WriteLine("After Division: {0}", result);
        }
        public void squroot()
        {
            Console.WriteLine("Enter a number to find it's Square-Root");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 < 0)
            {
                Console.WriteLine("Cannot take square root of a negative number!");
            }
            else
            {
                Console.WriteLine($"Result: {Math.Sqrt(num1)}");
            }
        }
        public void exponent()
        {
            Console.WriteLine("Enter Base number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Power:");
            double exp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{num1}^{exp}: {Math.Pow(num1, exp)}");
        }
    }
}
