/*using Calculator_app;
using System;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(String[] args)
    {
        int action;
        bool flag = true;
        void Menu()
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for exit");
            action = Convert.ToInt32(Console.ReadLine());
        }
        void Repeat()
        {
            Console.WriteLine("Do you want to continue?");
            string a = Console.ReadLine();
            if (a == "y" || a == "yes")
            {
                Menu();
            }
            else
            {
                flag = false;
            }
        }
        Menu();

        Calculator cal = new Calculator();

        while (flag)
        {
            switch (action)
            {
                case 1:
                    cal.Addition();
                    Repeat();
                    break;
                case 2:
                    cal.Subtraction();
                    Repeat();
                    break;
                case 3:
                    cal.Multiplication();
                    Repeat();
                    break;
                case 4:
                    cal.Division();
                    Repeat();
                    break;
                case 5:
                    flag = false;
                    break;
            }
        }
    }
}*/

using Calculator_app;
using System.Data;
public class Program
{
    public static void Main(String[] args)
    {
        int action;
        int choose;
        Main_menu();
        void Main_menu()
        {
            Console.WriteLine("-----CALCULATOR MAIN MENU-----");
            Console.WriteLine("1: Basic Operations  2: Mixed Operations");
            choose = Convert.ToInt32(Console.ReadLine());
        }

        bool flag = true;

        void Mixed_OP()
        {
            string input;
            double result;
            DataTable dt = new DataTable();
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");
            Console.WriteLine("Enter your calculations (e.g. 1+8*9/8+5), then press Enter:");
            Console.WriteLine("Type 'exit' to quit");
            while (true)
            {
                Console.WriteLine("Enter the Expression for evaluation");
                input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                try
                {
                    result = Convert.ToDouble(dt.Compute(input, ""));
                    Console.WriteLine("Result: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        if (choose == 1)
        {
            Console.WriteLine("---You are in BASIC OPERATIONS Section---");

            void Menu()
            {
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 for Addition and hit Enter");
                Console.WriteLine("Press 2 for Subtraction and hit Enter");
                Console.WriteLine("Press 3 for Multiplication and hit Enter");
                Console.WriteLine("Press 4 for Division and hit Enter");
                Console.WriteLine("Press 5 for Square-Root and hit Enter");
                Console.WriteLine("Press 6 for Exponent and hit Enter");
                Console.WriteLine("Press 7 to EXIT and hit Enter");
                action = Convert.ToInt32(Console.ReadLine());
            }
            void Repeat()
            {
                Console.WriteLine("Do you wish to continue? (y/n)");
                string a = Console.ReadLine();
                if (a == "y" || a == "yes")
                {
                    Menu();
                }
                else
                {
                    flag = false;
                }
            }
            Menu();
            Calculator cal = new Calculator();
            while (flag)
            {
                switch (action)
                {
                    case 1:
                        cal.Addition();
                        Repeat();
                        break;
                    case 2:
                        cal.Subtraction();
                        Repeat();
                        break;
                    case 3:
                        cal.Multiplication();
                        Repeat();
                        break;
                    case 4:
                        cal.Division();
                        Repeat();
                        break;
                    case 5:
                        cal.squroot();
                        Repeat();
                        break;
                    case 6:
                        cal.exponent();
                        Repeat();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        flag = false;
                        break;
                }
            }
        }
        else if (choose == 2)
        {
            Mixed_OP();
        }
    }
}