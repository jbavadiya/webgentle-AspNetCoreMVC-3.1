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
            return DataSource();
        }

        public BookModel GetAllBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            { 
               new BookModel(){Id =1, Title="MVC", Author = "Jignesha"},
               new BookModel(){Id =2, Title="Dot Net", Author = "Jignesh"},
               new BookModel(){Id =3, Title="C", Author = "Jigna"},
               new BookModel(){Id =4, Title="Java", Author = "Jigu"},
               new BookModel(){Id =5, Title="Php", Author = "Gnesha"}
            };
        }
    }
}
