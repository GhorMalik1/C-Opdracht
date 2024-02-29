using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int StudentNummer { get; set; }
    public int Leeftijd { get; set; } 

    public Student(string name, int studentNummer, int leeftijd)
    {
        Name = name;
        StudentNummer = studentNummer;
        Leeftijd = leeftijd;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Student> studentsDictionary = new Dictionary<int, Student>();

        List<string> studentNames = new List<string> { "Ghor", "Jan", "Bob", "Tom", "Klaas", "Tim", "David", "Milan", "Mehmet", "Omer" };

        List<int> leeftijdValues = new List<int> { 20, 22, 21, 19, 23, 24, 18, 25, 20, 22 };

        for (int i = 0; i < studentNames.Count; i++)
        {
            int leeftijd = leeftijdValues[i];
            Student student = new Student(studentNames[i], i + 1, leeftijd);
            studentsDictionary.Add(student.StudentNummer, student);
        }

        Student oudsteStudent = studentsDictionary.Values.OrderByDescending(s => s.Leeftijd).First();
        Console.WriteLine($"Oudste student: {oudsteStudent.Name} Leeftijd: {oudsteStudent.Leeftijd}");

        Console.WriteLine("\nLijst met studentennummers:");
        foreach (var studentNumber in studentsDictionary.Keys)
        {
            Console.WriteLine(studentNumber);
        }

        Console.WriteLine("\nLijst met studentennamen en leeftijden:");
        foreach (var student in studentsDictionary.Values)
        {
            Console.WriteLine($"Naam: {student.Name} Leeftijd: {student.Leeftijd}");
        }

        Console.WriteLine("\nLijst van studenten gesorteerd op leeftijd:");
        foreach (var student in studentsDictionary.Values.OrderBy(s => s.Leeftijd))
        {
            Console.WriteLine($"Naam: {student.Name} Leeftijd: {student.Leeftijd}");
        }
    }
}
