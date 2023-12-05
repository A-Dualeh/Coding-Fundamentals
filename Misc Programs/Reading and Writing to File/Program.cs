// Program to read in data from user using do-while and write/append to a file (learning points: files,do-while loop)

using System;
using System.IO;

class program
{
    static void Main(string[] args)
    {
        string filePath = "DaysOftheWeek.txt";
        string userInput;

        Console.Write("Enter days of the week (one per line and type 'End' when finished): \n");
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.Write("This is your input: \n");
            do
            {
                userInput = Console.ReadLine();
                if (userInput.ToLower() != "done")
                {

                    writer.Write(userInput+ "\n");
                  
                }

            } while (userInput.ToLower() != "done");
        }

        Console.WriteLine("The data has been written to the file located: " +Environment.CurrentDirectory);
      
    }
}