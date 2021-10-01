using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Bookish.Database;
using Bookish.Models;

namespace Bookish.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks(string searchBy, string search);
        Book GetOneBook(int bookId);
        void InsertBook(Book book);
        void DeleteBook(int bookId);
        void EditBook(Book book);
        List<Author> GetDropDownList();
    }

    public class BookService : IBookService
    {
        private readonly BookDB _bookDataBase;

        public BookService (BookDB bookModel)
        {
            _bookDataBase = bookModel;
        }

        public List<Book> GetAllBooks(string searchBy, string search)
        {
            List<Book> books = new List<Book>();

            if(searchBy == "Book")
                books = _bookDataBase.Books
                                    .Where(b=> b.Title.StartsWith(search) || search == null)
                                    .Include(a => a.Author)
                                    .ToList();
            else
                books = _bookDataBase.Books
                        .Include(a => a.Author)
                        .Where(a => a.Author.first_name.StartsWith(search) || a.Author.last_name.StartsWith(search)|| search == null)
                        .ToList();
            
            
            return books;
        }

        public void InsertBook(Book book)
        {
            _bookDataBase.Books.Add(book);
            _bookDataBase.SaveChanges();

        }

        public Book GetOneBook(int bookId)
        {
            Book book = _bookDataBase.Books.Include(a => a.Author).Single(b => b.BookId == bookId);
            
            return book;

        }

        public void DeleteBook(int bookId)
        {
            Book book = _bookDataBase.Books.Where(b => b.BookId == bookId).Single();
            _bookDataBase.Books.Remove(book);
            _bookDataBase.SaveChanges();
        }

        public void EditBook(Book book)
        {
            _bookDataBase.Entry(book).State = EntityState.Modified;
            _bookDataBase.SaveChanges();

        }

        public List<Author> GetDropDownList()
        {
            return (_bookDataBase.Authors.ToList());
        }

    }
}