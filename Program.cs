using System;
using System.Collections.Generic;
using System.Linq;

namespace ACTIVITY_5_ITEC104
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = test (new List<int>() { 10, 20, 35, 65, 53, 48, 5, 1 });

            Console.WriteLine("10, 20, 35, 65, 53, 48, 5, 1");

            foreach (var el in intList)
            {
                Console.Write(el.ToString() + " " );
            }
            Console.ReadKey();
        }
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 != 5 ).ToList();
        }
    }
}




