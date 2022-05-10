using P128HomeWork2.Enums;
using P128HomeWork2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork2.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }
        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string search);
        List<Book> Filter(string author, Genre genre);
    }
}
