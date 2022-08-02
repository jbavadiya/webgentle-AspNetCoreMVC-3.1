using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.Bookstore.Models;

namespace Webgentle.Bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return Datasource();
        }

        public BookModel GetBookById(int Id)
        {
            return Datasource().Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return Datasource().Where(x => x.Title == title || x.Author == authorName).ToList();
        }

        private List<BookModel> Datasource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="Mvc", Author = "Jignesha", Description="This is a description for MVC book", Catagory="Programming",TotalPages="123",Language="Eng" },
                new BookModel(){Id=2, Title="java", Author = "Anant", Description="This is a description for Java book", Catagory="Programming",TotalPages="1273",Language="Hindi"},
                new BookModel(){Id=3, Title="c", Author = "Pari", Description = "This is a description for c book", Catagory="Programming",TotalPages="4567",Language="Russian"},
                new BookModel(){Id=4, Title="c++", Author = "Hari", Description = "This is a description for c++ book", Catagory="Programming",TotalPages="567",Language="Nepali"},
                new BookModel(){Id=5, Title="javascript", Author = "Jigna", Description = "This is a description for Javascript book", Catagory="Programming",TotalPages="173",Language="Spanish"}
            };
        }
    }
}
