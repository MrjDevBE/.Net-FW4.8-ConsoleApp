using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndDemos.ClassCollection
{
    class ClassLogicalOperator
    {
        public static void LogicalOperator()
        {
            // Logic operators = can be use to check if more than 1 condition is true/false

            // && (and)
            // || (or)

            Console.WriteLine("What's the tempreture outside : (c)");
            double temp = Convert.ToDouble(Console.ReadLine());

                if (temp >= 10 && temp <= 10)
                {
                Console.WriteLine("It's warm outside!");
                }
                else if (temp <= 50 || temp >= 50)
                {
                Console.WriteLine("DO NOT GO outside!");
                }
        }
    }
}
