using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //variables
            double num01;
            double num02;
            double num03;
            double result01;
            double result02;

            //welcome
            Console.WriteLine("Hello, I will help you find \nthe average of three numbers!");

            //inputs
            
            Console.Write("Input a number: ");
            num01 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Now Input a SECOND Number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );
            Console.Write("Now Input the LAST Number: ");
            num03 = Convert.ToDouble( Console.ReadLine() );
            
            // end

            Console.WriteLine("Calculating");
            Console.WriteLine("Please Wait");
            
            result01 = num01 + num02 + num03;
            result02 = result01 / 3;
            Console.WriteLine("The result is " + result02 + ".");

            

            Console.ReadKey();
        }
    }
}
