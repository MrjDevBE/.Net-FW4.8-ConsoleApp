using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndDemos.ClassCollection
{
    class ClassForLoops
    {
        public static void ForLoops()
        {
            // for loop = repeats some a FINITE amount of times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("END");
            //for (int j = 0; j < 10; j+=3)
            //{
            //    Console.WriteLine(j);
            //}
        }
    }
}
