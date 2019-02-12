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
        static void whiteSpace(int level) // The function that show Spaces
        {
            for (int i = 0; i < level * 4; i++) // Cycle for showing Spaces
            {
                Console.Write(' '); // Show Spaces 
            }
        }
        static void print(string path, int level)
        {
            DirectoryInfo directory = new DirectoryInfo(path); // Write the path to the directory With which we works
            FileInfo[] fileInfos = directory.GetFiles();
            DirectoryInfo[] directoryInfos = directory.GetDirectories();
            foreach (FileInfo f in fileInfos) // Cycle for Files
            {
                whiteSpace(level); 
                Console.WriteLine(f.Name); // Show the Name of each file from the given directory
            }
            foreach (DirectoryInfo d in directoryInfos) // Cycle for Directories
            {
                whiteSpace(level);
                Console.WriteLine(d.Name);// Show the name of the Folders
                print(d.FullName, level + 1);
            }

        }

        static void Main(string[] args)
        {
            string path = @"C:\Users\acer\Desktop\c++";
            print(path, 0); //Call the function with path and 0(the number of spaces)
            Console.ReadKey();
        }
    }
}