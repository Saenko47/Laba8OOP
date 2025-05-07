using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Laba8OOP
{
    internal class Task1
    {
        public static void ShowCurrentTime()
        {
            Console.WriteLine($"Current time: {DateTime.Now}");
        }
        public static void ShowCurrentDate()
        {
            Console.WriteLine($"Current date: {DateTime.Now.ToShortDateString()}");
        }
        public static void ShowCurrentDay() {
        Console.WriteLine($"Current day: {DateTime.Now.DayOfWeek}");
        }
        public static void Task1Method1dot1(Action act)
        {
            act.Invoke();
        }
        /// 
        /// 
        ///
        /// 
        public static bool IsSimpleNumber(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        public static bool IsFib(int i)
        {
            int final = 0;
            int current = 1;
            int previous = 0;
           
            for (int k = 0;k<i; ++k)
            {
                if (final == i) return true;
                final = current + previous;
                previous = current;
                current = final;
               
            }
            return false;
        }
        public static void Task1Method1dot2(Predicate<int> predicate, int number)
        {
            bool result = predicate.Invoke(number);
            Console.WriteLine(result ? "True" : "False");
        }
        /// 
        /// 
        ///
        /// 
        public static double STriangle(int a, int b) {
            
            return (a * b) / 2;

        }
        public static double SRectangle(int a, int b) {
           
            return a * b;
        }
        public static void TaskMethod1dot3(Func<int,int,double> func,int a, int b)
        {
            Console.WriteLine(func.Invoke(a,b));

        }
    }
}
