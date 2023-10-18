//learning areas - Strings, Loops, Objects, Methods
using System;
class Palindrome
{
    public string Input { get; set; }

   public Palindrome(string input)
    { 
        Input = input; 
    }

    public bool isPalindrome()
    {
        string input = Input.ToLower(); 
        bool flag = true;

        for (int i = 0; i < input.Length/2; i++)
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
        string? input;


        while (true) 
        { 
            Console.WriteLine("Enter a string for Palindrome check (press 1 to quit): ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Bye!");
                break;
            }
              
             Palindrome palindrome = new Palindrome(input);

            if (palindrome.isPalindrome() == true)
                Console.WriteLine($"{input} is a Palindrome\n");
            else
                Console.WriteLine($"{input} is not a Palindrome\n");
        }    
    }
}