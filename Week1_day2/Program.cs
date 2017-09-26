using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day2
{
    class Program
    {
        static void Main(string[] args)
        {

            char firstInitial = 'B';
            bool istired = false;
            bool hasDog = true;

            //other number data types
            //FLOATS end with f
            float pi= 3.14f;

            //DECIMALS end with m
            decimal partialNum = 3.1416293m;

            //Holds more decimals than float and double
            //Use the type with least decimal places to have a program run more efficitent
            double someNumber = 2.16440d;

            Console.WriteLine(pi);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

        }
    }
}
