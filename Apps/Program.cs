using System;
using System.Collections;

namespace Apps 
{



    class Program
    {
        private static void Main(string[] args)
        {
            // Array
            var arrc = new char[] { 'b', 't', 'k' };

            // Array List

            var obj = new ArrayList();
            obj.Add(10);
            obj.Add('b');

            // List<T>

            var aryint = new List<int>();

            aryint.Add(10);
            aryint.Add((int)('b'));
            aryint.AddRange(new int[] {1,2,5,6});

            foreach (var i in aryint)
            {
                Console.WriteLine(i);
                              
            }

            Console.ReadKey();




        }
    }
    



}