using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_V2
{
    internal class Program
    {
        enum Operation { Sum = 1, Subtraction, Multiplication, Division, Module, Factorial }
        static void Main(string[] args)
        {
            string username = Environment.UserName;
            Console.WriteLine("Hello, " + username + "! Welcome to the Calculator V2, by José Fernandes!");
            bool cont = true;

            while (cont)

            {
                Console.Clear();
                Console.Write("Enter the first number: ");
                long num1 = long.Parse(Console.ReadLine());
                Console.WriteLine("\nNumber A: " + num1 + "\n");

                Console.Write("Enter the second number: ");
                long num2 = long.Parse(Console.ReadLine());
                Console.WriteLine("\nNumber A: " + num1);
                Console.WriteLine("Number B: " + num2 + "\n");

                Console.WriteLine("Wich operation do you want to use?");
                Console.WriteLine("1-Sum\n2-Subtraction\n3-Multiplication\n4-Division\n5-Module\n6-Factorial\n");
                Console.Write("R: ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("\n");
                Operation opcaoSelecionada = (Operation)index;

                double finalResp4 = num2 / num1;

                switch (opcaoSelecionada)

                {
                    case Operation.Sum:
                        double finalResp1 = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + finalResp1);
                        Console.WriteLine("Do you want to perform any further operations? (yes/no)");
                        string continuar1 = Console.ReadLine().ToLower();
                        cont = continuar1 == "yes";
                        break;

                    case Operation.Subtraction:
                        double finalResp2 = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + finalResp2);
                        Console.WriteLine("Do you want to perform any further operations? (yes/no)");
                        string continuar2 = Console.ReadLine().ToLower();
                        cont = continuar2 == "yes";
                        break;

                    case Operation.Multiplication:
                        double finalResp3 = num1 * num2;
                        Console.WriteLine(num1 + " x " + num2 + " = " + finalResp3);
                        Console.WriteLine("Do you want to perform any further operations? (yes/no)");
                        string continuar3 = Console.ReadLine().ToLower();
                        cont = continuar3 == "yes";
                        break;

                    case Operation.Division:
                        if (num2 != 0)
                        {
                            finalResp4 = num2 / num1;
                            Console.WriteLine(num1 + "  ÷ " + num2 + " = " + finalResp4);
                            Console.WriteLine("Do you want to perform any further operations? (yes/no)");
                            string continuar4 = Console.ReadLine().ToLower();
                            cont = continuar4 == "yes";
                        }

                        else
                        {
                            Console.WriteLine("Error: division by zero is not allowed!");
                            Console.WriteLine("Do you want to try again? (yes/no)");
                            string continuar5 = Console.ReadLine().ToLower();
                            cont = continuar5 == "yes";
                        }
                        break;

                    case Operation.Module:
                        num1 = Math.Abs(num1);
                        num2 = Math.Abs(num2);
                        Console.WriteLine("Module (absolute value) of the number A: " + num1);
                        Console.WriteLine("Module (absolute value) of the number B: " + num2);
                        Console.WriteLine("Do you want to perform any further operations? (yes/no)");
                        string continuar6 = Console.ReadLine().ToLower();
                        cont = continuar6 == "yes";
                        break;

                    case Operation.Factorial:
                        long response1 = FactorialLogic(num1);
                        long response2 = FactorialLogic(num2);
                        Console.WriteLine("The factorial of the " + num1 + " is " + response1);
                        Console.WriteLine("The factorial of the " + num2 + " is " + response2);
                        Console.WriteLine("Do you want to perform any further operations? (yes/no)");
                        string continuar7 = Console.ReadLine().ToLower();
                        cont = continuar7 == "yes";
                        break;

                }

                Console.WriteLine("\nThanks for use my calculator! See you in the next code!");
                Console.ReadKey();
            }
        }

        static long FactorialLogic(long a)
        {
            if (a == 0 || a == 1)
                return 1;

            long results = 1;
            
            for (int i = 1; i <= a; i++ )
            {
                results *= i;
            }
   
            return results;
        }
    }
}