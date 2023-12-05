// Program to print the sum of an Array for given range (learning points: Arrays)

using System;

public class CalculateRange
{
    private int[] Numbers;

    public CalculateRange(int[] numbers)
    {
        this.Numbers = numbers;
    }

    public int Sum(int start, int end)
    {
        int Sum = 0;

        for (int i = start; i <= end; i++)
        {
            Sum += Numbers[i];
        }
        return Sum;
    }

}

class Program
{

    static void Main(string[] args)
    {
        int[] numbers = { 3, 7, 2, 8, 3, 4, 3, 9, 3 };

        Console.WriteLine($"Enter the Start index of the Array(not negative): ");
        int inputStart = int.Parse(Console.ReadLine());

        if (inputStart < 0)
        {
            Console.WriteLine($"Input entered is less than zero");
        }

        else
        {
            Console.WriteLine($"Enter the End index of the Array(not greater than {(numbers.Length) - 1})");
            int inputEnd = int.Parse(Console.ReadLine());

            if (inputEnd < numbers.Length)
            {
                CalculateRange Calculator = new CalculateRange(numbers);
                int total = Calculator.Sum(inputStart, inputEnd);
                Console.WriteLine($"The sum is: {total}");
            }

            else
            {
                Console.WriteLine($"Input entered is greater than the last index of the Array({numbers.Length - 1})");
            }

        }


    }
}