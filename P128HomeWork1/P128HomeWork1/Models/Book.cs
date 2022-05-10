using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork1.Models
{
    class Book
    {

        private static int _count;

        public string Code { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        static Book()
        {
            _count = 1;
        }
        public Book(string name,string authorName, int pageCount)
        {
            Code = $"{name.Substring(0, 2).ToUpper()}{_count}";
            _count++;

            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override string ToString()
        {
            return $"{Code} {Name} {PageCount} {AuthorName}";
        }

    }   
}
