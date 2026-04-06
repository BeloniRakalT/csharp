using System;

namespace Assignment_6
{
    // Books class
    class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        // Constructor
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("Book: " + BookName + ", Author: " + AuthorName);
        }
    }

    // BookShelf class using composition
    class BookShelf
    {
        private Books[] bookList = new Books[5];

        // Indexer
        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < bookList.Length)
                    return bookList[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < bookList.Length)
                    bookList[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();

            // Assign values using indexer
            shelf[0] = new Books("The Alchemist", "Paulo Coelho");
            shelf[1] = new Books("Wings of Fire", "A.P.J Abdul Kalam");
            shelf[2] = new Books("Rich Dad Poor Dad", "Robert Kiyosaki");
            shelf[3] = new Books("Harry Potter", "J.K. Rowling");
            shelf[4] = new Books("The Hobbit", "J.R.R. Tolkien");

            // Display all books
            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }

            Console.ReadLine();
        }
    }
}