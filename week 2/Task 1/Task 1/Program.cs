using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp16
{
    class Program
    {
        

        static bool polindrome(string s) // create function to check for polindrome
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\acer\Desktop\input.txt"); //read file;
            string s = sr.ReadToEnd(); 
            sr.Close(); // closing sr
            if (polindrome(s)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadKey(); 
        }
        
        
    }
}
