# Grade-Calculator
An application, using a solution algorithm that uses logical and relational expressions, that calculates the percentage and final grade for students in a class. The application will prompt to enter the students first and last name, and the number of points the student received. The application only accepts scores between 0 and 1,000 points (including 0 and 1,000), with 1,000 points being the maximum number of points. If the input value is within the valid range, the program will display a  “good score” message; otherwise, the program will display an error message and then terminate the program. The program then  calculates the score percentage and then displays the student’s first name, last name, number of points, calculated percentage, and final grade.

# Variables & IPO Model
![Variables & IPO Model](https://raw.githubusercontent.com/kiddjsh/Grade-Calculator/main/images/Variable%20%26%20IPO%20Model.PNG)

# Flowchart
![Flowchart_2](https://raw.githubusercontent.com/kiddjsh/Grade-Calculator/main/images/Flowchart_2.PNG)
![Flowchart_3](https://raw.githubusercontent.com/kiddjsh/Grade-Calculator/main/images/Flowchart_3.PNG)
![Flowchart_4](https://raw.githubusercontent.com/kiddjsh/Grade-Calculator/main/images/Flowchart_4.PNG)

# My C# Solution
```C#
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
```

# Complete Working Program
![Complete Working Program_1](https://raw.githubusercontent.com/kiddjsh/Grade-Calculator/main/images/Complete%20Working%20Program_1.PNG)
![Complete Working Program_2](https://raw.githubusercontent.com/kiddjsh/Grade-Calculator/main/images/Complete%20Working%20Program_2.PNG)

