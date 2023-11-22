// Program to add students scores to a list, do basic List functions and write to a file (learning points: Lists, file IO, get/set, string override)

using System;
using System.IO;
using System.Collections.Generic;


public class Student
{
    private string name;
    private int id;
    private double score;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Id
    {
        get { return id; }     
        set { id = value; }
    }

    public double Score
    {
        get { return score; }
        set { score = value; }
    }

    public Student(string Name, int Id, double Score)
    {
        name = Name;
        id = Id;       
        score = Score;
    }
    public override string ToString()
    {
        return $"Student: {name}\nId: {id}\nScore: {score}";
    }
}

public class StudentManager
{
    List<Student> students = new List<Student>();

    public void AddStudent()
    {
        Console.WriteLine("Enter Student name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Student Id: ");
        int id = int.Parse(Console.ReadLine());

        double score;
        bool validScore = false;

        do
        {
            Console.WriteLine("Enter Student score (0-100): ");
            if (double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
            {
                validScore = true;
            }
            else
            {
                Console.WriteLine("Invalid score. Enter a number between 0 and 100.");
            }
        } while (!validScore);
        students.Add(new Student(name, id, score));

        Console.WriteLine("Student added.\n");
    }

    public void ViewStudent()
    {
        string filepath = "StudentList.txt";

        using StreamWriter writer = new StreamWriter(filepath, true);
        {

            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
                writer.WriteLine("-----------------");
                writer.WriteLine(student);
                
            }
        }
    }

   
    public void ViewHighestScore()
    {
        Student highestScoringStudent = students.OrderByDescending(student => student.Score).FirstOrDefault();
        Console.WriteLine($"Highest scoring student: {highestScoringStudent.Name}");
        Console.WriteLine($"Score: {highestScoringStudent.Score}");
        Console.WriteLine();
    }

    public void AverageScore()
    {
        double average = students.Average(student => student.Score);

        Console.WriteLine($"The Average score is: {average}\n");
    }

}


class Program
{
    
    static void Main(string[] args)
    {
        StudentManager studentManager = new StudentManager();

        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add student to list");
            Console.WriteLine("2. View Student list: ");
            Console.WriteLine("3. View Student with highest score: ");
            Console.WriteLine("4. View average score of the students: ");
            Console.WriteLine("5. Quit Program: ");
            Console.WriteLine();

            string input= Console.ReadLine();

            switch (input)
            {
                case "1":
                    studentManager.AddStudent();
                    break;
                
                case "2":
                    studentManager.ViewStudent();
                    break;
                
                case "3":
                    studentManager.ViewHighestScore();
                    break;

                case "4":
                    studentManager.AverageScore();
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid input - Try again");
                    break;
               
            }
                 
        }

    }

}