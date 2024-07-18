using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndDemos.ClassCollection
{
    class ClassStringMethod
    {
        public static void StringMethod()
        {
            String fullName = "Bro Code ";
            String phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-","");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0,"Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length); // get the length of string

            // String firstName = fullName.Substring(0, 3);
            //String lastName = fullName.Substring(4, 4);

            fullName.Trim(); // remove white spaces

            Console.WriteLine(fullName);
           // Console.WriteLine(lastName);
        }
    }
}
