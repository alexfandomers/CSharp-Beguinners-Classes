using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassBeginners
{
    public class Person
    {
         public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}