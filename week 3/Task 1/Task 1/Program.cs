using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Task_1
{
    class Program
    {
        static void print(DirectoryInfo d, int cursor)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            FileSystemInfo[] fsis = d.GetFileSystemInfos();
            for (int i = 0; i < fsis.Length; i++)
            {
                if (fsis[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (i == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine((i + 1) + "." + fsis[i].Name);
            }

        }
        
        public static void Main(String[] args)
        {
            string path = @"C:\Users\acer\Desktop";
            DirectoryInfo d = new DirectoryInfo(path);
            int cursor = 0;
            int n = d.GetFileSystemInfos().Length;
            print(d, cursor);
            while (true)
            {
                FileSystemInfo[] fsis = d.GetFileSystemInfos();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor == -1)
                    {
                        cursor = n - 1;
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                    {
                        cursor = 0;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        d = new DirectoryInfo(fsis[cursor].FullName);
                        n = d.GetFileSystemInfos().Length;
                        cursor = 0;
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(fsis[cursor].FullName);
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(sr.ReadToEnd());
                        Console.ReadKey();
                    }
                }
                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (d.Parent != null)
                    {
                        d = d.Parent;
                        cursor = 0;
                        n = d.GetFileSystemInfos().Length;
                    }
                    else
                    {
                        break;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Delete)
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        Directory.Delete(fsis[cursor].FullName, true);
                    }
                    else
                    {
                        File.Delete(fsis[cursor].FullName);
                    }
                }
                if (keyInfo.Key == ConsoleKey.R)
                {
                    if (fsis[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        Console.Clear();
                        string s = Console.ReadLine();
                        string k = fsis[cursor].FullName;
                        string name = fsis[cursor].Name;
                        int len = name.Length;
                        string newpath = "";
                        for (int i = 0; i < k.Length - len; i++)
                        {
                            newpath = newpath + k[i];
                        }
                        newpath = newpath + s;
                        Directory.Move(k, newpath);
                    }
                    else
                    {
                        Console.Clear();
                        string s = Console.ReadLine();
                        string k = fsis[cursor].FullName;
                        string name = fsis[cursor].Name;
                        int len = name.Length;
                        string newpath = "";
                        for (int i = 0; i < k.Length - len; i++)
                        {
                            newpath = newpath + k[i];
                        }
                        newpath = newpath + s;
                        File.Move(k, newpath);
                    }

                }
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                print(d, cursor);
            }

        }
    }
}