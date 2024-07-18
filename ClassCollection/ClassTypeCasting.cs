using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndDemos.ClassCollection
{
    static class ClassTypeCasting
    {
        // type casting = Converting a value to a different data type
        //                Useful when we accept user input (string)
        //                Different data types can do different things
        public static void TypeCasting()
        { 
            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());
        }

    }
}
