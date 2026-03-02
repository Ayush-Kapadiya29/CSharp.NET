

// palindrome   number
// Enrollment number : 92400527008
// Name : Ayush Kapadiya
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int reversed = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number = number / 10;
        }

        if (originalNumber == reversed)
            Console.WriteLine("It is palindrome");
        else
            Console.WriteLine("It is not palindrome");
    }
}