// factorial
// Enrollment number : 92400527008
// Name : Ayush Kapadiya

using System;


namespace Unit_3_8_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i, fact = 1;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial = " + fact);
        }
    }
}
