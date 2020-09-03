using System;
using System.Collections.Generic;


namespace UnitTesting
{
    class Program
    {
        public static Library<Book> Library { get; set; }
        public static Library<Book> BookBag { get; set; }

        static void Main(string[] args)
        {
            Library = new Library<Book>();
            BookBag = new Library<Book>();
            Console.WriteLine("Welcome to the library");
            Console.WriteLine("Entwer a number for the command you want. 1: View Books 2: Add a book");
            string input = Console.ReadLine();

            if(input == "1")
            LoadBooks();

        }

        static void LoadBooks()
        {
            AddABook("That", "Me", "You", 400, Genre.Comic);
            AddABook("F******", "Me", "You", 400, Genre.Comic);
            AddABook("B****", "Me", "You", 300, Genre.Fantasy);
            AddABook("Carole", "Me", "You", 200, Genre.Horror);
            AddABook("Baskin", "Me", "You", 100, Genre.Mystery);
            int counter = 1;
            foreach (Book book in Library)
            {
                Console.WriteLine($"{counter++} : {book.Title}, {book.Author.FirstName}, {book.Author.LastName}, {book.NumberOfPages} {book.Genre}");  
            }
        }

        static void AddABook(string title, string firstName, string lastName, int numberOfPages, Genre genre)
        {
            Book book = new Book()
            {
                Title = title,
                Author = new Author(firstName, lastName)
                {
                    FirstName = firstName,
                    LastName = lastName
                },
                NumberOfPages = numberOfPages,
                Genre = genre
            };
            Library.Add(book);
        }
    }
}
