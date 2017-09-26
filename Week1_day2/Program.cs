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

            // Arithmetic OPPERATORS:
            // + add or combines two data types
            // - subtraction
            // * multiplication
            // / division (4/2 = 2; 2/4 = .5)
            // % modulus
            // ++ takes an int and incease by 1

            // Relational Opperators:
            // -- decreases int by 1
            // == checks if the values of two operants are euqal
                // if they are equal, returns true
            // != checks if 2 operants are equal or not
                // if values are NOT equal, returns bool true
                // Is this wrong? If wrong then the bool is true
            // > greather than
            // < less than
            // >= greather than or equal to
            // </ less than or equal to

            int jarradAge = 29;
            int danielAge = 32;
            Console.WriteLine(jarradAge == danielAge);
            Console.WriteLine(jarradAge != danielAge);

        }
    }
}
