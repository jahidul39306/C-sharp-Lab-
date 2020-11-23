using System;
using System.Collections.Generic;
using System.Text;

namespace Libary_Management
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        private Book[] books;

        public Book[] Books
         {
             get { return books; }
             set { books = value; }
         }
        public Student()
        {
            Book[] books = new Book[5];
            Console.WriteLine("Empty Constructor");
        }

        private Account stuAac;
            
        public Account StuAcc
        {
            get { return stuAac; }
            set { stuAac = value; }
        }

        public Student(string name, string id, string department, float cgpa)
        {
            Book[] books = new Book[5];
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + Cgpa);
        }
        
        public void AddBorrowBooks(Book book)
        {
            bool flag = true;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                    Console.WriteLine("Book Added");
                    flag = false;
                    break;
                }
            }
            if (flag) { Console.WriteLine("5 Book has already added"); }
        }

        public void DeleteBorrowBooks(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Equals(book))
                {
                    books[i] = null;
                    Console.WriteLine("Book returned");
                }
            }
        }

        public void BorrowedBooksInfo()
        {
            foreach(var e in books)
            {
                e.ShowInfo();
                Console.WriteLine();
            }
        }


    }
}
