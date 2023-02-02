/*
* Name:Anthony Perez
* Course: COMP-003A
* Purpose: Assignment 3 code
*/

namespace COMP003A.Assignment3;
class Program
{
    static void Main(string[] args)
    {
        // Console Section
        Console.ForegroundColor = ConsoleColor.White;

        //If-Else Section
        Console.WriteLine("Enter grade number");
        string? input = Console.ReadLine();
        double numericGrade = Convert.ToDouble(input);
        if (numericGrade >= 90)
            Console.WriteLine("A");
        else if (numericGrade >= 80)
            Console.WriteLine("B");
        else if (numericGrade >= 70)
            Console.WriteLine("C");
        else if (numericGrade >= 60)
            Console.WriteLine("D");
        else if (numericGrade < 60)
            Console.WriteLine("F");
        else
            Console.WriteLine("Invalid Input");
        
        //Switch Section
        Console.WriteLine("Enter day (an integer 0-7) ");
        string input2 = Console.ReadLine();
        int numericDay = Convert.ToInt32(input2);
        switch (numericDay)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }

    }
}

