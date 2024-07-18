using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndDemos.ClassCollection
{
    class ClassWhileLoops
    {
        public static void WhileLoops()
        {

            // while loop = repeats some code while some condition remains true

            String name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

        }
    }
}
