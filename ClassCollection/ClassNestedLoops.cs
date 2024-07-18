using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndDemos.ClassCollection
{
    class ClassNestedLoops
    {
        public static void NestedLoops()
        {
            // Nested loops = loops inside of other loops
            //                  uses vary. used a lot in sorting algorithms

            Console.WriteLine("How many rows?");
            int rows = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("How many rows?");
            int colums = Convert.ToInt32(Console.ReadLine());

            Console.Write("What Symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
