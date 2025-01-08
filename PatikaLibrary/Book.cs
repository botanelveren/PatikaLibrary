using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibrary
{
    public class Book
    {
        public string Name { get; set; } 
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public DateTime RecordDate { get; set; }

        public Book() 
            {
            RecordDate = DateTime.Now;
            }
        public Book(string name, string author, int numberOfPages, string publisher)
        {
            Name = name;
            Author = author;
            NumberOfPages = numberOfPages;
            Publisher = publisher;
            RecordDate = DateTime.Now;
        }
    }
}
// The Book is a class that has four properties: Name, Author, NumberOfPages, and Publisher. A class is a blueprint for creating objects (a particular data structure).
// New is the keyword that creates an instance of the Book class. It creates two instances of the Book class: book1 and book2.
// The Book class has two constructors that initialize the properties of the Book class. Those are the default constructor and the parameterized constructor.