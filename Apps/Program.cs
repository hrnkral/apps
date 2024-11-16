using System;
using System.Collections;

namespace Apps 
{



    class Program
    {
        private static void Main(string[] args)
        {
            var p1 = new DataStructures.Array.Array<int>(1,2,3,4);
            var p2 = new int[] {5,6,7,8,9};
            var p3 = new List<int> { 10, 11, 12, 13, 14, 15 };
            var p4 = new ArrayList() { 16, 17, 18, 19, 20, 21, 22 }; // ArrayList is not type safe

            var arr = new DataStructures
                .Array
                .Array<int>(p1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }




            


            Console.ReadKey();




        }

        private static void basitOrnek()
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
            aryint.AddRange(new int[] { 1, 2, 5, 6 });

            foreach (var i in aryint)
            {
                Console.WriteLine(i);

            }
        }
    }
    



}