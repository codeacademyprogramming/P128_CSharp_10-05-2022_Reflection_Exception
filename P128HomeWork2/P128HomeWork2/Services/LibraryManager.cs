using P128HomeWork2.Enums;
using P128HomeWork2.Exceptions;
using P128HomeWork2.Interfaces;
using P128HomeWork2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork2.Services
{
    class LibraryManager : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            if (_books.Exists(b=>b.Name == book.Name))
                throw new SameBookalreadyAddedExpection($"{book.Name} adli kitab artiq movcuddur");

            _books.Add(book);
        }

        public List<Book> Filter(string author, Genre genre)
        {
            //List<Book> books = null;

            //if (string.IsNullOrWhiteSpace(author))
            //    books = _books.FindAll(b => b.Author.ToLower() == author.ToLower());

            //if ((int)genre > 0 && (int)genre <= 3)
            //    books = _books.FindAll(b => b.Author.ToLower() == author.ToLower() && b.Genre == genre);

            //return books;

            return _books.FindAll(b => b.Author.ToLower() == author.ToLower() && b.Genre == genre);
        }

        public List<Book> Search(string search)
        {
            return _books.FindAll(b => b.Name.ToLower().Contains(search.ToLower()) || 
            b.Author.ToLower().Contains(search.ToLower()) || 
            b.Genre.ToString().ToLower().Contains(search.ToLower()) || 
            b.PageCount.ToString().ToLower().Contains(search.ToLower()));
        }

        public Book ShowInfo(string name)
        {
            Book book = _books.Find(b => b.Name.ToLower() == name.ToLower());

            if (book == null)
                throw new BookNotFoundException($"{name} adli kitab tapilmadi");

            return book;
        }
    }
}
