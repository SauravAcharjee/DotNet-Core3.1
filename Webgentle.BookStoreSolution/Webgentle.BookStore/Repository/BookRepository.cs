using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().FirstOrDefault( b => b.Id == id );
            //return DataSource().Where(book => book.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
           return DataSource().Where(book => book.Title.Contains(title) || book.Author.Contains(author)).ToList();
           
        }   

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title ="MVC with Core", Author = "Saurav" },
                new BookModel(){Id = 2, Title ="MVC Framwork", Author = "Subhas" },
                new BookModel(){Id = 3, Title ="MVVC", Author = "Saikat" },
                new BookModel(){Id = 4, Title ="MVC In Java", Author = "Aabir" },
                new BookModel(){Id = 5, Title ="MVC In Intersystems Cache", Author = "Robin" },
            } ;
        }
    }
}
