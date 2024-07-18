using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndDemos.ClassCollection
{
    class ClassVariables
    {
        public static void Varialbles()
        {
            int x; // declaration
            x = 123; // initialization
            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 21; // whole integer
            double height = 300.5; // decimal number
            bool alive = false; //true or false
            char symbol = '@'; // single character
            String name = "Bro"; // a series of characters

            Console.WriteLine("Hello " + name);
                Console.WriteLine("Your age is " + age);
                Console.WriteLine("Your height is " + height + "cm");
                Console.WriteLine("Are you alive? " + alive);
                Console.WriteLine("Your symbol is: " + symbol);

                String userName = symbol + name;

            Console.WriteLine("Your username is: " + userName);
        }
    }
}
