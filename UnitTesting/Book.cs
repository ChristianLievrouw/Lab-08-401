using System;
namespace UnitTesting
{
    class Book
    {
        public Author Author { get; set; }

        public string Title { get; set; }

        public int NumberOfPages { get; set; }

        public Genre Genre { get; set; }

    }

    enum Genre
    {
        Mystery,
        Comic,
        Fantasy,
        Horror,
        Thrillers
    }
}
