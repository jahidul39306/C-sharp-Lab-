using System;
using System.Collections.Generic;
using System.Text;

namespace Libary_Management
{
    class Library
    {
        private string libName;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }

        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

        private Book[] listOfBook;

        public Book[] ListOfBook
        {
            get { return listOfBook; }
            set { listOfBook = value; }
        }

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }

        public Library()
        {
            Book[] listOfBook = new Book[1000];
        }

        public Library(string libName, string libAddress)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            //this.totalBook = totalBook;
        }

        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name: " + LibName);
            Console.WriteLine("Library Address: " + LibAddress);
            //Console.WriteLine("Total Book: " + TotalBook);
        }

        public void ShowAllBooks()
        {
            foreach (var e in listOfBook)
            {
                e.ShowInfo();
            }
        }

        public void AddNewBook(Book book)
        {
            bool flag = true;
            for(int i = 0; i < listOfBook.Length; i++)
            {
                if(listOfBook[i] == null)
                {
                    listOfBook[i] = book;
                    totalBook++;
                    Console.WriteLine("Book Added");
                    flag = false;
                    break;
                }
            }
            if(flag) { Console.WriteLine("Can not assign book for oversize"); } 
            /*if (totalBook < 1000)
            {
                listOfBook[totalBook++] = book;
            }*/
        }
        public void DeleteBook(Book book)
        {
            for (int i = 0; i < listOfBook.Length; i++)
            {
                if(listOfBook[i].Equals(book))
                { 
                    listOfBook[i] = null;
                    Console.WriteLine("Book Deleted");
                }
            }
        }

        public void AddNewBookCopy(Book book, int copy)
        {
            book.AddBookCopy(copy);
        }
    }
}
