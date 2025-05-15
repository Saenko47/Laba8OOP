using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba8OOP
{
    internal class Task3
    {
        public static int Task3Methods1(int[] arr, int i)
        {
            int k = 0;
            switch (i)
            {
                case 1:
                    Func<int[], int> func = arr => { int count = 0; for (int j = 0; j < arr.Length; ++j) { if (arr[j] % 7 == 0) { ++count; } }return count; };
                    k = func(arr);
                    break;
                case 2:
                    Func<int[], int> func1 = arr => { int count = 0; for (int j = 0; j < arr.Length; ++j) { if (arr[j] > 0) { ++count; } } return count; };
                    k = func1(arr);
                    break;
                default : Console.WriteLine("Invalid input"); break;
            }
            return k;
        }
        public static void Task3Method2()
        {
            Func<bool> func = () => { bool Is; if (DateTime.Now.DayOfYear == 256) { Is = true; } else { Is = false; } return Is; };
            if (func()) { Console.WriteLine("Today day of coder, yappy"); }
            else { Console.WriteLine("Not today, i guess(((((("); }
        }
        public static void Task3Method3(string text,string word) 
        {
            Func<string, string, bool> func = (text, word) => {return text.Contains(word); };
         


        }
        public static void Task3Method3(string text, string[] words)
        {
            Func<string, string[], bool> funcForArr = (text, words) =>
            {
                string[] strings = text.Split(' ');
                foreach (string word in words)
                {
                    if (strings.Contains(word))
                    {
                        return true;
                    }
                }
                return false;
            };
            
            
        }
    }
}
