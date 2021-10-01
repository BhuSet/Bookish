using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{

    public class Author
    {
        public int AuthorId { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public List<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}