using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> students = ReadStudents();
        PrintStudents(students);
    }

    private static void PrintStudents(List<Student> students)
    {
        foreach (Student student in students.Where(x => x.AvgGrd >= 5.00).OrderBy(x => x.Name).ThenByDescending(y => y.AvgGrd))
        {
            Console.WriteLine($"{student.Name} -> {student.AvgGrd:f2}");
        }
    }

    private static List<Student> ReadStudents()
    {
        int num = int.Parse(Console.ReadLine());
        List<string> input = new List<string>();
        List<Student> students = new List<Student>();
        List<Student> finalResult = new List<Student>();

        for (int i = 0; i < num; i++)
        {
            Student currentStudent = new Student();
            input = Console.ReadLine().Split(' ').ToList();
            currentStudent.Name = input[0];
            input.RemoveAt(0);
            currentStudent.Grades = input.Select(x => double.Parse(x)).ToList();
            students.Add(currentStudent);
        }

        return students;
    }
}
