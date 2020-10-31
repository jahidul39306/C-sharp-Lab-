using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_3
{
    class Course
    {
        String courseName;
        String courseCode;
        int courseCredit;
        public String CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }
        public String CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }
        public int CourseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Course Name: {0}", CourseName);
            Console.WriteLine("Course Code: {0}", CourseCode);
            Console.WriteLine("Course Credit: {0}", CourseCredit);
        }
    }
}
