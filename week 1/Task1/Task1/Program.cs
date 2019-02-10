using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        //function to check for prime numbers
        public static bool check(string n)
        {
            //converting a string into an integer 
            int num = int.Parse(n);
            if (num <= 1)
                return false;
            else
            {
                for (int i = 2; i < num; i++)
                    if (num % i == 0)
                        return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Created the variable n which is the amount of numbers in array
            string s = Console.ReadLine();
            string[] ar = s.Split(); // Array in which every element is the number from s devided by space
            int[] array = new int[n]; // The array with n numbers
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(ar[i]); // Record every value from ar into int  to array
            }
            int cnt = 0; // Counter for calculating prime numbers
            for (int i = 0; i < n; i++)
            {
                if (check(ar[i]) == true) // The condition Which is performed if the Function  returns true 
                {
                    cnt++; // Counting prime numbers
                }
            }
            Console.WriteLine(cnt); // Show the total amount of prime numbers 
            for (int i = 0; i < n; i++)
            {
                if (check(ar[i]) == true) // Condition which comes into if the function returns true when the number is prime
                    Console.Write(array[i] + " "); // Show the prime number
            }
            Console.ReadKey();
        }
    }
}
