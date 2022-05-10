using System;
using System.Collections.Generic;
using System.Text;

namespace P124DemoLibrary
{
    public class Human
    {
        private string FullName { get; set; }
        public string Name { get; set; }
        public byte Age;

        private string Info(string p128)
        {
            return $"{p128} Code Academy";
        }
    }
}
