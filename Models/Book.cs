using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    
    public class Book 
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "Title of the Book is Required")]
        public string Title { get; set; }
        public int Published_year { get; set; }
        public int TotalCopies { get; set; }
        public int CurrentAvailableCopies { get; set; }
        
        public int CurrentAuthorId {get; set;}
        public Author Author {get; set; }
        

        /*public Book()
        {

        }
    
        public Book (int id, string Title, string Author, int Published_year)
        {
            Id = id;
            Title = Title;
            Published_year = Published_year;
            Author = Author;
        }*/
    }

    public class BookQuantities
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Published_year { get; set; }
        public int CurrentAuthorId {get; set;}
        public Author Author {get; set; }
        public int TotalCopies { get; set; }
    }
}
