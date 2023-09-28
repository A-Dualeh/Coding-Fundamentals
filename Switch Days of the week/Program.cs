// Program to read in a string for day of the week and use a switch statement(learning points: switch)

using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a day of the week: ");
      
        string input=Console.ReadLine()?.ToLower();

        switch(input)
        {

            case "monday":

                Console.WriteLine("You selected Monday");
                break;

            case "tuesday":

                Console.WriteLine("You selected Tuesday");
                break;

            case "wednesday":

                Console.WriteLine("You selected Wednesday");
                break;

            case "thursday":

                Console.WriteLine("You selected Thursday");
                break;

            case "friday":

                Console.WriteLine("You selected Friday");
                break;

            case "saturday":

                Console.WriteLine("You selected Saturday");
                break;
            
            case "sunday":

                Console.WriteLine("You selected Sunday");
                break;

            default:
                Console.WriteLine("You entered an invalid day of the week");
                break;

        }

    }

}