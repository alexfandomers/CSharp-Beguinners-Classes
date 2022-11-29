using System;
using System.Collections.Generic;
using System.Text;
using ClassBeginners;

namespace ClassBeginners
{                   
     
    public class Program
    {
        static void Main(string[] args)
        {  
          var karl = new Person();
          karl.FirstName = "Karl";
          karl.LastName = "walk";
          karl.Introduce();

          Calculator calculator = new Calculator();
          var result = calculator.Add(1,2);
          Console.WriteLine(result);
        }
                
    }
}

