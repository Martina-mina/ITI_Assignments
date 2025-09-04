using System.Collections.Generic;
using System.Linq;

namespace task3_day1
{

    class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] subjects { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            
        List<Student> students = new List<Student>()
        {
            new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
                subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){ Code=33,Name="UML"}}},
            new Student(){ ID=2, FirstName="Mona", LastName="Gala",
                subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){ Code=34,Name="XML"}, new Subject(){ Code=25,Name="JS"}}},
            new Student(){ ID=3, FirstName="Yara", LastName="Yousf",
                subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){ Code=25,Name="JS"}}},
            new Student(){ ID=1, FirstName="Ali", LastName="Ali",
                subjects=new Subject[]{ new Subject(){ Code=33,Name="UML"}}}
        };

       
        Console.WriteLine("Query1:");
        var q1 = students.Select(s => new { FullName = s.FirstName + " " + s.LastName, Count = s.subjects.Length });
        foreach (var s in q1)
            Console.WriteLine($"{s.FullName} - {s.Count}");

        
        Console.WriteLine("Query2:");
        var q2 = students.OrderByDescending(s => s.FirstName)
                         .ThenBy(s => s.LastName)
                         .Select(s => new { s.FirstName, s.LastName });

        foreach (var s in q2)
            Console.WriteLine($"{s.FirstName} {s.LastName}");
    

        }
    }
}
