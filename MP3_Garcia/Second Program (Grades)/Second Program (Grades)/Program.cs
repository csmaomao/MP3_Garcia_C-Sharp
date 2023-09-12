using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Program__Grades_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a program that accepts the Prelim Grade, Midterm Grade, and Final Grade. Compute for the final term grade following 
             the formula [30% Prelim Grade + 30% Midterm Grade + 40% Final Grade]. Display the Final Term Grade together with the 
             Point Grade Equivalent*/

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("SEMESTRAL GRADE to GRADE POINT EQUIVALENT");
            Console.WriteLine("-----------------------------------------");

            //Asking for input and storing them in their respective variables
            Console.Write("Input Prelim Grade: ");
            float prelim = Int32.Parse(Console.ReadLine());
            Console.Write("Input Minterm Grade: ");
            float midterm = Int32.Parse(Console.ReadLine());
            Console.Write("Input Final Grade: ");
            float finals = Int32.Parse(Console.ReadLine());

            //computation for the final term grade
            double prelimGrade = prelim * 0.3;
            double midtermGrade = midterm * 0.3;
            double finalGrade = finals * 0.4;
            double grade = prelimGrade + midtermGrade + finalGrade;

            //used to round off the final grade, ensuring that x.5 and above will round upwards while x.4 will round down
            double roundOff = Math.Floor(grade + 0.5);

            //printing the final grade and it's rounded off equivalent
            Console.WriteLine("\nYour Final Term Grade is: " + grade);
            Console.WriteLine("Rounded Off to: " + roundOff);
            
            //if statements to convert the final term grade to its point grade equivalent
            if (roundOff >= 97)
            {
                Console.WriteLine("\nYour GPA is: 1.00");
            }
            else if (roundOff >= 93)
            {
                Console.WriteLine("\nYour GPA is: 1.25");
            }
            else if (roundOff >= 89)
            {
                Console.WriteLine("\nYour GPA is: 1.50");
            }
            else if (roundOff >= 85)
            {
                Console.WriteLine("\nYour GPA is: 1.75");
            }
            else if (roundOff >= 82)
            {
                Console.WriteLine("\nYour GPA is: 2.00");
            }
            else if (roundOff >= 79)
            {
                Console.WriteLine("\nYour GPA is: 2.25");
            }
            else if (roundOff >= 76)
            {
                Console.WriteLine("\nYour GPA is: 2.50");
            }
            else if (roundOff >= 73)
            {
                Console.WriteLine("\nYour GPA is: 2.75");
            }
            else if (roundOff >= 70)
            {
                Console.WriteLine("\nYour GPA is: 3.00");
            }
            else if (roundOff < 70)
            {
                Console.WriteLine("\nYour GPA is: 5.00");
            }
            else 
            {
                Console.WriteLine("\nNo Grade");
            }

            Console.ReadKey(); 
        }
    }
}
