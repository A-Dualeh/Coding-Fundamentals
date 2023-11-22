//learning areas - Polymorphism, Object key word

using System;
class PalindromeChecker
{
    public object Input { get; set; }

    public PalindromeChecker(object input)
    {
        Input = input;
    }

    public virtual bool isPalindrome()
    {
        return false;
    }
}

class StringPalindromeChecker : PalindromeChecker
{
    public StringPalindromeChecker(string input) : base(input)
    {
    }
    public override bool isPalindrome()
    {
        string input = Input.ToString().ToLower();
        bool flag = true;

        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - i - 1])
            {
                flag = false;
                break;
            }
        }
        return flag;
    }

}
class IntegerPalindromeChecker : PalindromeChecker
{
    public IntegerPalindromeChecker(int input) : base(input)
    {
    }
    public override bool isPalindrome()
    {
        string input = Input.ToString();
        bool flag = true;

        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - i - 1])
            {
                flag = false;
                break;
            }
        }
        return flag;
    }

}

class Program
{
    static void Main(string[] args)
    {
        string inputString;


        while (true)
        {
            Console.WriteLine("Enter a string or an integer for Palindrome check (press 1 to quit): ");
            inputString = Console.ReadLine();

            if (inputString == "1")
            {
                Console.WriteLine("Bye!");
                break;
            }

            if (int.TryParse(inputString, out int inputInt))
            {
                PalindromeChecker palindromeChecker = new IntegerPalindromeChecker(inputInt);
                Console.WriteLine($"You entered integer {inputInt}. Palindrome result is: {palindromeChecker.isPalindrome()}");
            }
            else
            {
                PalindromeChecker palindromeChecker = new StringPalindromeChecker(inputString);
                Console.WriteLine($"You entered string {inputString}. Palindrome result is: {palindromeChecker.isPalindrome()}");
            }
        }
    }
}