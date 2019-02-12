using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program {
        static int[] ArrMaker(string[] a)   //  method that makes out of an array of integers another array of integers, where every element is repeated
        {
            int[] array = new int[a.Length * 2]; // create an array whose size is doubled
            int cnt = -1;                       //position in array
            for (int i = 0; i < a.Length; i++)
            {
                cnt++;      // increasing cnt by one                        
                array[cnt] = int.Parse(a[i]); //array[0] = 1
                cnt++;  
                array[cnt] = int.Parse(a[i]); // array[1] = 1
            }
            return array;
        }
    
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //Created the variable n which is the amount of numbers in array
            int n = int.Parse(s);
            string k = Console.ReadLine();
            string[] arr = k.Split(' '); // Array in which every element is the number from k devided by space

            int[] array = ArrMaker(arr);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]); //Show an array
                Console.Write(' ');
            }
            Console.ReadKey();
        }
    } }
