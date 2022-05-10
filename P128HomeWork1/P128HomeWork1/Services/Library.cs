using P128HomeWork1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork1.Services
{
    class Library
    {
        List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string name)
        {
            return _books.FindAll(b => b.Name.ToLower().Contains(name.ToLower()));
        }

        public void RemoveAllBookByName(string name)
        {
            _books.RemoveAll(b => b.Name.ToLower().Contains(name.ToLower()));
        }

        public List<Book> SearchBooks(string search)
        {
            return _books.FindAll(b => b.Name.ToLower().Contains(search.ToLower()) || 
                                        b.AuthorName.ToLower().Contains(search.ToLower()) || 
                                        b.PageCount.ToString().Contains(search.ToLower()));
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return _books.FindAll(b => b.PageCount >= min && b.PageCount <= max);
        }

        public void RemoveByNo(string code)
        {
            //Book book = _books.Find(b => b.Code == code.ToUpper());

            //if (book != null)
            //{
            //    _books.Remove(book);
            //}

            if (_books.Exists(b => b.Code == code.ToUpper()))
                _books.Remove(_books.Find(b => b.Code == code.ToUpper()));
        }
    }
}
