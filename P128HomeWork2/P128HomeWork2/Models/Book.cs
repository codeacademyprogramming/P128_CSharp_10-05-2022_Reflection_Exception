using P128HomeWork2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork2.Models
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public byte PageCount { get; set; }
        public Genre Genre { get; set; }
    }
}
