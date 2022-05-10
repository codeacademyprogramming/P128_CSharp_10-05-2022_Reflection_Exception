using System;
using System.Collections.Generic;
using System.Text;

namespace P128HomeWork2.Exceptions
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string msg) : base(msg)
        {

        }
    }
}
