using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorV1
{
    namespace Calculator_V2
    {
        internal class Program
        {
            enum Operation { Sum = 1, Subtraction, Multiplication, Division }
            static void Main(string[] args)
            {
                string username = Environment.UserName;
                Console.WriteLine("Hello, " + username + "! Welcome to the Calculator!");
                bool cont = true;

                while (cont)

                {
                    Console.Clear();
                    Console.Write("Enter the first number: ");
                    long num1 = long.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    long num2 = long.Parse(Console.ReadLine());

                    Console.WriteLine("Wich operation do you want to use?");
                    Console.WriteLine("1-Sum\n2-Subtraction\n3-Multiplication\n4-Division\n");
                    int index = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    Operation opcaoSelecionada = (Operation)index;

                    double finalRes = num2 / num1;

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
                                finalRes = num2 / num1;
                                Console.WriteLine(num1 + "  ÷ " + num2 + " = " + finalRes);
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


                    }
                }

            }
        }
    }
}
    

