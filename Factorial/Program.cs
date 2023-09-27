// Program to print the Factorial of a given input (learning points: Methods, Constructors, For Loops, Objects, input/output)
using System;

public class CalculateFactorial
{
    private int initial;
    public CalculateFactorial(int input)
    {
        this.initial = input;
    }

    public double Calculate()
    {
        double factorial = 1;
        for (int i = initial; i > 0; i--)
        {
            factorial *= i;
        }
        return factorial;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        double answer;
        Console.WriteLine($"Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            if (userInput <= 0)
            {
                Console.WriteLine("Value is not positive or greater than 0. ");
            }
            else
            {
                CalculateFactorial calculator = new CalculateFactorial(userInput);
                answer = calculator.Calculate();
                Console.WriteLine($"Factorial is: {answer}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer");
        }
    }
}