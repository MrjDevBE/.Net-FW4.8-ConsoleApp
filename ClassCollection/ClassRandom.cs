using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndDemos.ClassCollection
{
    class ClassRandom
    {
        public static void Random()
        {
            Random random = new Random();

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            //double num = random.NextDouble();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

        }
    }
}
