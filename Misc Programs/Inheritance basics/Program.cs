using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
}

class Student : Person
{
    public int StudentId { get; set; }

    public Student(string firstName, string lastName, int age, int studentId)
       : base(firstName, lastName, age)
    {
        StudentId = studentId;
    }   
}

class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string firstName, string lastName, int age, string subject)
       : base(firstName, lastName, age)
    {
        Subject = subject;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Jason", "Bourne", 30, 001);
        Teacher teacher = new Teacher("James", "Bond", 35, "Spy101");

        Console.WriteLine("Student:");
        Console.WriteLine($"First Name: {student.FirstName}");
        Console.WriteLine($"Last Name: {student.LastName}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"Student Id: {student.StudentId}\n");

        Console.WriteLine("Teacher: ");
        Console.WriteLine($"First Name: {teacher.FirstName}");
        Console.WriteLine($"Last Name: {teacher.LastName}");
        Console.WriteLine($"Age: {teacher.Age}");
        Console.WriteLine($"Subject: {teacher.Subject}");
    }
}