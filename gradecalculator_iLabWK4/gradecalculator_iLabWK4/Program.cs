using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradecalculator_iLabW4
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable list
            double studentScore = 0;
            double studentPercent;
            string firstName = "";
            string lastName = "";
            string grade = "";
            string user = "";

            //output greeting
            Console.ForegroundColor = ConsoleColor.Green;
            user = Console.ReadLine();
            Console.WriteLine("Hi! Welcome to the Grade Calculator.");
            Console.ForegroundColor = ConsoleColor.Green;

            //inputs from user
            Console.ForegroundColor = ConsoleColor.Green;
            user = Console.ReadLine();
            user = Console.ReadLine();
            Console.Write("Please enter the Students First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Please enter the Students Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Please enter the Students Score: ");
            studentScore = Convert.ToInt32(Console.ReadLine());
            

            //calculations 
            if (studentScore < 0 || studentScore > 1000)
            {
                Console.Write("_________________________________________________________________");
                user = Console.ReadLine();
                Console.WriteLine("Error: Entry Is Invalid. Please enter a value between 0 - 1000.");
                Console.Write("Press any key to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Good Score!");
                user = Console.ReadLine();
                Console.Write("_________________________________________________________________");
                user = Console.ReadLine();
                studentPercent = studentScore / 1000 * 100;
                if (studentPercent >= 0.90)
                {
                    grade = "A";
                }
                else if (studentPercent >= 0.80)
                {
                    grade = "B";
                }
                else if (studentPercent >= 0.70)
                {
                    grade = "C";
                }
                else if (studentPercent >= 0.60)
                {
                    grade = "D";
                }
                else grade = "F";
                {
                }

                //outputs
                Console.Write("First Name of the Student: " + firstName);
                user = Console.ReadLine();
                Console.Write("Last Name of the Student: " + lastName);
                user = Console.ReadLine();
                Console.Write("Total Points scored by student: " + studentScore);
                user = Console.ReadLine();
                Console.Write("Total Percentage of student: " + studentPercent + " %");
                user = Console.ReadLine();
                Console.Write("Student's Grade: " + grade);
                user = Console.ReadLine();
                Console.Write("_________________________________________________________________");
                user = Console.ReadLine();
                user = Console.ReadLine();
                Console.Write("Thank you for using the Grade Calculator!");
                user = Console.ReadLine();
                Console.Write("Press any key to continue...");
                Console.ReadLine();

            }
        }
    }
}
