// Created by Aurimas A. Nausedas on 08/18/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;
namespace Hashtables
{
    public class Student
    {

        //property called Id
        public int Id { get; set; }

        //property called NAME
        public string Name { get; set; }

        // property called GPA
        public float GPA { get; set; }

        // simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
