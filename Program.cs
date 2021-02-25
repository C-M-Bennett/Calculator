using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value followed by enter");
            string firstValue = Console.ReadLine();
            double firstDouble = Convert.ToDouble(firstValue);

            Console.WriteLine("Enter a mathematical operation followed by enter");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter a second value followed by enter");
            string secondValue = Console.ReadLine();
            double secondDouble = Convert.ToDouble(secondValue);

            Console.WriteLine("Calculating...");

            double result = 0;
         
            
            void PerformCalculation(double firstDouble, string operation, double secondDouble)
            {
                if (operation == "+")
                {
                    result = firstDouble + secondDouble;
                }

                else if (operation == "-")
                {
                    result = firstDouble - secondDouble;
                }

                else if (operation == "*")
                {
                    result = firstDouble * secondDouble;
                }

                else if (operation == "/")
                {
                    result = firstDouble / secondDouble;
                }

                else
                {
                    Console.WriteLine("Does not compute!");
                }

            }


            PerformCalculation(firstDouble, operation, secondDouble);

            Console.WriteLine($"The answer is {result}");

        }
    }
}
