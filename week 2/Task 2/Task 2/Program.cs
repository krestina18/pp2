using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_2
{
    class Program
    {
        //create function to check for prime
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
            StreamReader sr = new StreamReader(@"C:\Users\acer\Desktop\input.txt"); 
            string s = sr.ReadToEnd(); // Wrire the text down from The giving "input"
            sr.Close();
            string[] arr = s.Split();// create the array Where every element is written by spaces from s
            StreamWriter sw = new StreamWriter(@"C:\Users\acer\Desktop\output.txt");
            string res = ""; //create an empty string
            for (int i = 0; i < arr.Length; i++) //Cycle which works from 0 to the length of the array
            {
                int num = int.Parse(arr[i]); // parcing array elements into integer
                if (prime(num)) 
                {
                    res = res + num + ' '; // adding all primes to res
                }
            }
            sw.Write(res); 
            sw.Close();
        }
    }
}