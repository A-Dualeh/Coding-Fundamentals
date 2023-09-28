// Program to reverse the words in a String Array (learning points: Arrays of type String)
using System;

public class PrintReverse
{

    private string[] Words;
    private string[] ReversedOutput;

    public PrintReverse(string[] words)
    {
        this.Words = words;
        this.ReversedOutput = new string[Words.Length];

    }
    public void GenerateReversal(string[] InputWords)
    {
         
        for (int i=0; i<InputWords.Length; i++)
        {
            ReversedOutput[i] = InputWords[InputWords.Length-1-i];
            Console.WriteLine(" " + ReversedOutput[i]);
        }

    }

}

public class Program
{ 
    static void Main(string[] args)
    {
        string[] WordsArray = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        
        PrintReverse WordsReversed = new PrintReverse(WordsArray);
        WordsReversed.GenerateReversal(WordsArray); 
        
    }

}
