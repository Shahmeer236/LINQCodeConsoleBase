using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 5, Name = "Shahmeer", Marks = 50, Phone = "03022712236", Email = "shahmeer@gmail.com" });
            students.Add(new Student { Id = 1, Name = "Ausaja", Marks = 50, Phone = "0302271234", Email = "Ausaja@gmail.com" });
            students.Add(new Student { Id = 3, Name = "Areeb", Marks = 70, Phone = "03030234234", Email = "Areeb@gmail.com" });
            students.Add(new Student { Id = 2, Name = "Maaz", Marks = 80, Phone = "030227132423", Email = "Maaz@gmail.com" });
            students.Add(new Student { Id = 4, Name = "Maisum", Marks = 80, Phone = "0030345345", Email = "Maisum@gmail.com" });

            var groupedStudents = from student in students
                                  group student by student.Marks;

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Students with Marks: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.Id}\t{student.Name}\t{student.Phone}\t{student.Email}\t{student.Marks}");
                }
                Console.WriteLine();
            }
        }

        class Student
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public int Marks { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }
    }
}
