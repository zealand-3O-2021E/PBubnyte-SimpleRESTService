using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_REST_Service.Managers
{
    public class BooksManager
    {
        public static List<Book> Data = new List<Book>
        {
            new Book {ISBN13 = "111", Author = "Person1", Title = "Title1", PageNumber = 11},
            new Book {ISBN13 = "222", Author = "Person2", Title = "Title2", PageNumber = 22},
            new Book {ISBN13 = "333", Author = "Person3", Title = "Title3", PageNumber = 33},
        };
        public List<Book> GetAll()
        {
            return new List<Book>(Data);
        }

        public Book GetByISBN13(string ISBN13)
        {
            return Data.Find(book => book.ISBN13.Contains(ISBN13));
        }

        public Book Add(Book newBook)
        {
            Data.Add(newBook);
            return newBook;
        }

        public Book Delete(string ISBN13)
        {
            Book book = Data.Find(book1 => book1.ISBN13.Contains(ISBN13));
            if (book == null) return null;
            Data.Remove(book);
            return book;
        }

        public Book Update(string ISBN13, Book updates)
        {
            Book book = Data.Find(book1 => book1.ISBN13.Contains(ISBN13));
            if (book == null) return null;
            book.Title = updates.Title;
            book.PageNumber = updates.PageNumber;
            book.Author = updates.Author;
            return book;
        } 
    }
}
