using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasuresConverterV2
{
    internal class Program { 

        enum ConversionOptions
    {
        CelsiusToFahrenheit = 1,
        CelsiusToKelvin,
        FahrenheitToCelsius,
        FahrenheitToKelvin,
        KelvinToCelsius,
        KelvinToFahrenheit,
        Exit
    }
    
        static void Main(string[] args)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Temperature Converter");
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Celsius to Fahrenheit");
                    Console.WriteLine("2. Celsius to Kelvin");
                    Console.WriteLine("3. Fahrenheit to Celsius");
                    Console.WriteLine("4. Fahrenheit to Kelvin");
                    Console.WriteLine("5. Kelvin to Celsius");
                    Console.WriteLine("6. Kelvin to Fahrenheit");
                    Console.WriteLine("7. Exit");

                    if (Enum.TryParse(Console.ReadLine(), out ConversionOptions choice) && Enum.IsDefined(typeof(ConversionOptions), choice))
                    {
                        if (choice == ConversionOptions.Exit)
                        {
                            Console.WriteLine("Exiting the program...");
                            break;
                        }

                        Console.Write("Enter the temperature value: ");
                        if (double.TryParse(Console.ReadLine(), out double value))
                        {
                            double result = PerformConversion(choice, value);
                            Console.WriteLine($"Converted value: {result:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }

            static double PerformConversion(ConversionOptions option, double value)
            {
                switch (option)
                {
                    case ConversionOptions.CelsiusToFahrenheit:
                        return CelsiusToFahrenheit(value);
                    case ConversionOptions.CelsiusToKelvin:
                        return CelsiusToKelvin(value);
                    case ConversionOptions.FahrenheitToCelsius:
                        return FahrenheitToCelsius(value);
                    case ConversionOptions.FahrenheitToKelvin:
                        return FahrenheitToKelvin(value);
                    case ConversionOptions.KelvinToCelsius:
                        return KelvinToCelsius(value);
                    case ConversionOptions.KelvinToFahrenheit:
                        return KelvinToFahrenheit(value);
                    default:
                        return value;
                }
            }

            static double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            static double CelsiusToKelvin(double celsius)
            {
                return celsius + 273.15;
            }

            static double FahrenheitToCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }

            static double FahrenheitToKelvin(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9 + 273.15;
            }

            static double KelvinToCelsius(double kelvin)
            {
                return kelvin - 273.15;
            }

            static double KelvinToFahrenheit(double kelvin)
            {
                return (kelvin - 273.15) * 9 / 5 + 32;
            }
        }
    }



    



