using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Lab_Task_3
{
    class Student
    {
        String name;
        String id;
        String department;
        float cgpa;
        public String Name
        {
            set { name = value; }
            get { return name; }
        }
        public String Id
        {
            set { id = value; }
            get { return id; }
        }
        public String Department
        {
            set { department = value; }
            get { return department; }
        }
        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Student Name: {0}", Name);
            Console.WriteLine("Student ID: {0}", Id);
            Console.WriteLine("Student Department: {0}", Department);
            Console.WriteLine("Student CGPA: {0}", Cgpa);
        }
    }
}
