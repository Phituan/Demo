using System;
using System.Collections.Generic;
using ConsoleApplication4.Properties;

namespace ConsoleApplication4
{
    internal class Program
    {
        private static List<Student> list = new List<Student>();

        private static void Main(string[] args)
        {
            GenerateMenu();
        }

        private static void SearchByName()
        {
            Console.WriteLine("please enter name to search: ");
            var searchKey = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                Student student = list[i];
                if (student.Name == searchKey)
                {
                    Console.WriteLine("found");
                    Console.WriteLine(student.RollNumber + "_" + student.Name);
                }
            }
        }

        private static void AddStudent()
        {
            var student = new Student();
            Console.WriteLine("enter name");
            student.Name = Console.ReadLine();
            Console.WriteLine("enter email");
            student.Email = Console.ReadLine();
            Console.WriteLine("enter phone");
            student.Phone = Console.Read();
            list.Add(student);
//            Console.WriteLine("do you want to enter ");
        }

        private static void DisplayStudent()
        {
            foreach (var student in list)
            {
                Console.WriteLine(student.Name);
            }
        }

        private static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("---------------Student manager-------------");
                Console.WriteLine("Add new student");
                Console.WriteLine("Show list student");
                Console.WriteLine("Search student by name");
                Console.WriteLine("Exit.");
                Console.WriteLine("Please enter your choice: ");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DisplayStudent();
                        break;
                    case 3:
                        SearchByName();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}