using System;

namespace consoleApp_001
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables:
            int num1;
            int num2;
            int sum;
            int result;


            string linea1;
            string linea2;
            Ejercicios ejercicio = new Ejercicios;

            //Start
            Console.WriteLine("Enter number to compare: ");
            linea1 = Console.ReadLine();
            num1 = int.Parse(linea1);

            Console.WriteLine("Enter another number to compare: ");
            linea2 = Console.ReadLine();
            num2 = int.Parse(linea2);

            if (num1 > num2)
            {
                sum = num1 + num2;
                result = sum * 3;

                Console.WriteLine("the result is: " + result);
                Console.ReadKey();

            }

            else
            {
                Console.Clear();
                Console.WriteLine(" system ERROR !!! ");
                Console.ReadKey();

            }
        }
    }
}
