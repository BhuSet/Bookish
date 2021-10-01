using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers
{
    
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorService;

        public AuthorController(ILogger<AuthorController> logger, IAuthorService authorService)
        {
            _logger = logger;
            _authorService = authorService;
        }

        [HttpGet("/Author")]
        public IActionResult Index()
        {
            if ( TempData["message"] != null)
            {
                ViewBag.SuccessMessage = TempData["message"].ToString();
                TempData.Remove("message");

            }
            return View(_authorService.GetAllAuthors());
        }
        
        [HttpGet("/Author/{authorId}")]
        public IActionResult GetAuthor(int authorId)
        {
            Author author = _authorService.GetOneAuthor(authorId);
            return View(author);
        }


        [HttpGet("/Author/addauthor")]
        public IActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAuthor(Author author)
        {
            _authorService.InsertAuthor(author);
            ModelState.Clear(); // Clears the value on submit

            ViewBag.SuccessMessage = "Author Added Successfully";
            return View();
        }

        [HttpGet("/Author/delete/{authorId}")]
        public IActionResult DeleteAuthor(int authorId)
        {
            _authorService.DeleteAuthor(authorId);
            TempData["message"] = "Author Deleted Successfully";
            
            return RedirectToAction("Index");
        }

        [HttpGet("/Author/edit/{authorId}")]
        public IActionResult EditAuthor(int authorId)
        {
            Author author = _authorService.GetOneAuthor(authorId);
            
            return View(author);
        }

        [HttpPost("/Author/edit/{authorId}")]
        public IActionResult EditAuthor(Author author)
        {
            _authorService.EditAuthor(author);
            ModelState.Clear();
            
            TempData["message"] = "Author Edited Successfully";
            
            return RedirectToAction("Index");
        }
    }
}
