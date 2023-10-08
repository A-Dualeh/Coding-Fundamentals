using System;
using System.Collections.Generic;

public class Book
{
    public string Title {  get; set; } 
    public string Author { get; set; }
    public int PublicationYear { get; set; } 

    public Book(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }
        
    public override string ToString()
    {
        return $"Name: {Title}, Author: {Author}, Publication Year: {PublicationYear}";
    }

}

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a new book");
            Console.WriteLine("2. Display all books");
            // Console.WriteLine("3. Search for a book by title");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the title:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter the author:");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter the publication year:");
                    int year = int.Parse(Console.ReadLine());

                    books.Add(new Book(title, author, year));
                    Console.WriteLine("Book added!");
                    break;

                case "2":
                    {
                        foreach (var book in books)
                        {
                            Console.WriteLine(book);
                        }

                        break;
                    }
                case "3":
                    {
                        return;
                    }
                default:
                    {

                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                    }
            }

        }
    }
}