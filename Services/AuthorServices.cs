using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Bookish.Database;
using Bookish.Models;

namespace Bookish.Services
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthors();
        Author GetOneAuthor(int authorId);
        void InsertAuthor(Author author);
        void DeleteAuthor(int authorId);
        void EditAuthor(Author author);
    }

    public class AuthorService : IAuthorService
    {
        private readonly BookDB _authorDataBase;

        public AuthorService (BookDB bookModel)
        {
            _authorDataBase = bookModel;
        }

        public List<Author> GetAllAuthors()
        {
            List<Author> authors = _authorDataBase.Authors.Include(a => a.Books).ToList();
            return authors;
        }

        public void InsertAuthor(Author author)
        {
            _authorDataBase.Authors.Add(author);
            _authorDataBase.SaveChanges();

        }

        public Author GetOneAuthor(int authorId)
        {
            //Author author = _authorDataBase.Authors.Where(b => b.AuthorId == authorId).Single();
            Author author = _authorDataBase.Authors.Include(a => a.Books).Single(a => a.AuthorId == authorId);
            return author;

        }

        public void DeleteAuthor(int authorId)
        {
            Author author = _authorDataBase.Authors.Where(b => b.AuthorId == authorId).Single();
            _authorDataBase.Authors.Remove(author);
            _authorDataBase.SaveChanges();
        }

        public void EditAuthor(Author author)
        {
            _authorDataBase.Entry(author).State = EntityState.Modified;
            _authorDataBase.SaveChanges();

        }

    }
}