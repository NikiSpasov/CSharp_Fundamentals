using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main()
    {

        List<Student> studentsList = new List<Student>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end of dates")
            {
                break;
            }
            Student currentStudent = new Student();
            List<string> inputArr = input.Split(' ', ',').ToList();
            currentStudent.Name = inputArr[0];
            inputArr.RemoveAt(0);
            if (inputArr == null)
            {
                studentsList.Add(currentStudent);
            }
            else
            { 
            currentStudent.Attend = inputArr.Select(DateTime.Parse).ToList();
            studentsList.Add(currentStudent);
            }
        }

        Dictionary<string, string> studentAndComments = new Dictionary<string, string>();
        while (true)
        {
            List<string> input = Console.ReadLine()
                .Split('-').ToList();

            if (input[0] == "end of comments")
            {
                break;
            }

            studentAndComments.Add(input[0], input[1]);
        }

        foreach (var student in studentsList)
        {
            foreach (var comment in studentAndComments)
            {
                if (student.Name == comment.Key)
                {
                    student.Comments = comment.Value.Split().ToList();
                }
            }
        }

        foreach (var student in studentsList.OrderBy(x => x.Name).ThenBy(x => x.Attend.OrderBy(y => y)))
        {
            Console.WriteLine(student.Name);
            if (student.Comments == null)
            {
                Console.WriteLine("Comments:");
            }
            else
            {
                Console.WriteLine("Comments:");
                Console.WriteLine("- " + string.Join(" ", student.Comments));
            }
            Console.WriteLine("Dates attended:");
            for (int i = 0; i < student.Attend.Count; i++)
            {
                Console.WriteLine("--" + student.Attend[i].ToString("dd'/'MM'/'yyyy"));
            } 
        }
    }
}