﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Libary_Management
{
    class Book
    {
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        private string bookAuthor;

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        private string bookId;

        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        private string bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }

        private int bookCopy;

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public Book()
        {
            Console.WriteLine("Empty Constructor");
        }

        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.BookCopy = bookCopy;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Book Name: " + BookName);
            Console.WriteLine("Book Author: " + BookAuthor);
            Console.WriteLine("Book ID: " + BookId);
            Console.WriteLine("Book Type: " + BookType);
            Console.WriteLine("Book Copy: " + BookCopy);
        }

        public void AddBookCopy(int x)
        {
            bookCopy = bookCopy + x;
        }
    }
}
