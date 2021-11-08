// Created by Aurimas A. Nausedas on 08/18/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();
            Hashtable table = new Hashtable();

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" }
            };

            Student[] students = new Student[5];

            students[0] = new Student(1, "Joe", 98);
            students[1] = new Student(2, "Al", 95);
            students[2] = new Student(3, "Tim", 77);
            students[3] = new Student(4, "John", 88);
            students[4] = new Student(1, "Jim", 71);

            Student stud1 = new Student(1, "Joe", 98);
            Student stud2 = new Student(2, "Al", 95);
            Student stud3 = new Student(3, "Tim", 77);
            Student stud4 = new Student(4, "John", 88);

            foreach (Student std in students)
            {
                if (!table.ContainsKey(std.Id))
                {
                    table.Add(std.Id, std);
                    Console.WriteLine("Student with ID{0} was added!", std.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, a student with the same ID already exists: {0}", std.Id);
                }
            }

            studentTable.Add(stud1.Id, stud1);
            studentTable.Add(stud2.Id, stud2);
            studentTable.Add(stud3.Id, stud3);
            studentTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentTable[1]; // need to cast to Student otherwise an error
            Student storedStudent2 = (Student)studentTable[stud2.Id];

            // retrieve individual item with Id
            Console.WriteLine("Student Id: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            Console.WriteLine("Student Id: {0}, Name: {1}, GPA: {2}", storedStudent2.Id, storedStudent2.Name, storedStudent2.GPA);

            // retrieve all values from hashtable
            foreach (DictionaryEntry entry in studentTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student Id: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }

            foreach (Student value in studentTable.Values) // Don't need to cast to students object
            {
                Console.WriteLine("Student Id: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }

        }
    }
}
