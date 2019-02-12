using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1 { 
    class Program
    {   //create function to check for prime
        static bool prime(int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();// Created the variable n which is the amount of numbers in array
            int n = int.Parse(s);
            string k = Console.ReadLine();
            string[] arr = k.Split(' ');// Array in which every element is the number from k devided by space
            int cnt = 0; // Counter for calculating prime numbers
        for (int i = 0; i < n; i++)
            {
                int num = int.Parse(arr[i]); 
            if (prime(num) == true) // The condition Which is performed if the Function returns true
                {
                    cnt++; // Counting prime numbers
            }
            }
            Console.WriteLine(cnt); // Show the total amount of prime numbers 
        for (int i = 0; i < n; i++)
            {
                int num = int.Parse(arr[i]); 
                if (prime(num) == true) // Condition which comes into if the function returns true when the number is prime
            {
                    Console.Write(num); // Show the prime number
                Console.Write(' ');
                }
            }
            Console.ReadKey();
        }
    }
}