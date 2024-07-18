using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndDemos.ClassCollection
{
    class ClassIfStatement
    {
        public static void IfStatement()
        {
            //if statement = a basic form of decision making

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }

        }
    }
}
