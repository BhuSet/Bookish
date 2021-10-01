using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.Services;
using Bookish.Database;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Controllers
{
    
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet("/Book")]
        public IActionResult Index(string searchBy, string search)
        {
            if ( TempData["message"] != null)
            {
                ViewBag.SuccessMessage = TempData["message"].ToString();
                TempData.Remove("message");

            }
            /*List<Book> books = new List<Book>();
            books = _bookService.GetAllBooks(searchBy, search);
            List<BookQuantities> tempbooks = books.GroupBy(b => new { b.Title, b.CurrentAuthorId, b.Published_year, b.Author})
                            .Select(b => new BookQuantities()
                            {
                                Title = b.Key.Title,
                                Published_year = b.Key.Published_year,
                                CurrentAuthorId = b.Key.CurrentAuthorId,
                                TotalCopies = b.Count(),
                                Author = b.Key.Author
                            })
                            .ToList();*/
            return View(/*tempbooks */_bookService.GetAllBooks(searchBy, search));
        }
        
        [HttpGet("/Book/{bookId}")]
        public IActionResult GetBook(int bookId)
        {
            Book book = _bookService.GetOneBook(bookId);
            if ( TempData["message"] != null)
            {
                ViewBag.Message = TempData["message"].ToString();
                TempData.Remove("message");
            }

            return View(book);
        }


        [HttpGet("/Book/addbook")]
        public IActionResult AddBook()
        {
            ViewBag.Dropdownlist = _bookService.GetDropDownList();
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookService.InsertBook(book);
            
            ModelState.Clear(); // Clears the value on submit
            ViewBag.Dropdownlist = _bookService.GetDropDownList();
            ViewBag.SuccessMessage = "Book Added Successfully";
            return View();
        
        }

        [HttpGet("/Book/delete/{bookId}")]
        public IActionResult DeleteBook(int bookId)
        {
            //_bookService.DeleteBook(bookId);
            TempData["message"] = "Are you sure to Delete ?";
            
            return RedirectToAction("GetBook", "Book", new{bookId = bookId});
        }

        [HttpPost("/Book/delete/{bookId}")]
        public IActionResult DeleteBookDone(int bookId)
        {
            _bookService.DeleteBook(bookId);
            TempData["message"] = "Book Deleted Successfully";
            
            return RedirectToAction("Index");
        }

        [HttpGet("/Book/edit/{bookId}")]
        public IActionResult EditBook(int BookId)
        {
            ViewBag.Dropdownlist = _bookService.GetDropDownList();
            Book book = _bookService.GetOneBook(BookId);  
            return View(book);
        }

        [HttpPost("/Book/edit/{bookId}")]
        public IActionResult EditBook(Book book)
        {
            _bookService.EditBook(book);
            
            TempData["message"] = "Book Edited Successfully";
            
            return RedirectToAction("Index");
        }
    }
}
