using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.Bookstore.Models;
using Webgentle.Bookstore.Repository;

namespace Webgentle.Bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

       public ViewResult GetAllBooks()
        {
           var booksData = _bookRepository.GetAllBooks();
               return View(booksData);
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);

        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
