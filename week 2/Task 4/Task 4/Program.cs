using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C: \Users\acer\Desktop\input.txt"); //  Creat the file int the folder below 2 files from the initial path
            sw.Write("34t56765"); //Fill in the file
            sw.Close(); //close file
            File.Copy(@"C:\Users\acer\Desktop\input.txt", @"C:\Users\acer\Desktop\pp1lab\kres2.txt"); //Copy File From the Initial path to another path
            File.Delete(@"C:\Users\acer\Desktop\input.txt"); // Deleted original file
            Console.ReadKey();
        }
    }
}
