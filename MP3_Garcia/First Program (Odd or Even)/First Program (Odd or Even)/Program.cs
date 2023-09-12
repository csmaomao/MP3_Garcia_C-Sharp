using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Program__Odd_or_Even_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------");
            Console.WriteLine("ODD OR EVEN?");
            Console.WriteLine("------------");

            //asks the user to input an integer for the program to determine its classification
            Console.Write("Input a Number: ");
            int number = Int32.Parse(Console.ReadLine());

            //turns negative input into positive for the program to determine whether it is odd or even
            int absValue = Math.Abs(number);

            //if-else statement for odd or even
            //if the user input has a remainder of 1 then it will be odd, otherwise it is even
            if(absValue % 2 == 1){

                Console.WriteLine(number + " is an odd number");

            }else {

                Console.WriteLine(number + " is an even number");
            }
            Console.ReadLine();
        }
    }
}
