using System;

namespace Assignment_5
{
    // Books Class
    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine("Book: " + BookName + " | Author: " + AuthorName);
        }
    }

    // BookShelf Class (Indexer + Aggregation)
    public class BookShelf
    {
        private Books[] books = new Books[5];

        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                    return books[index];
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index >= 0 && index < books.Length)
                    books[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }

    // Main Program
    internal class progra
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();

            // Assign books using indexer
            shelf[0] = new Books("The Alchemist", "Paulo Coelho");
            shelf[1] = new Books("Wings of Fire", "A.P.J Abdul Kalam");
            shelf[2] = new Books("Harry Potter", "J.K Rowling");
            shelf[3] = new Books("Rich Dad Poor Dad", "Robert Kiyosaki");
            shelf[4] = new Books("Think and Grow Rich", "Napoleon Hill");

            Console.WriteLine("--- Book Details ---");
            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }
        }
    }
}