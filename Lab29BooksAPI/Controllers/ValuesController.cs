using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab29BooksAPI.Models;

namespace Lab29BooksAPI.Controllers
{
    public class ValuesController : ApiController
    {

        // GET api/values/5
        public List<Book> GetListOfBooks()
        {
            EntertainmentEntities db = new EntertainmentEntities();
            List<Book> books = db.Books.ToList();

            return books;
        }

        // POST api/values
        public List<Book> GetBooksByCategory(string id)
        {
            EntertainmentEntities db = new EntertainmentEntities();
            List<Book> books = (from b in db.Books
                                where b.Category == id
                                select b).ToList();
            return books;
        }

        public Book GetRandomBook()
        {
            EntertainmentEntities db = new EntertainmentEntities();
            List<Book> books = (from b in db.Books
                                select b).ToList();

            Random rdm = new Random();

            int r = rdm.Next(0, books.Count());

            Book randomBook = books[r];

            return randomBook;

        }
        // PUT api/values/5
        public Book GetRandomBook(string id)
        {
            EntertainmentEntities db = new EntertainmentEntities();
            List<Book> books = (from b in db.Books
                                where b.Category == id
                                select b).ToList();

            Random rdm = new Random();

            int r = rdm.Next(0, books.Count());

            Book randomBook = books[r];

            return randomBook;

        }

        public List<Book> GetRandomBookList(int id)
        {
            EntertainmentEntities db = new EntertainmentEntities();
            List<Book> books = (from b in db.Books
                                select b).ToList();

            Random rdm = new Random();

            List<Book> randomBooks = new List<Book>();

            for(int i = 0; i < id; i++) {

                int r = rdm.Next(0, books.Count());

                randomBooks.Add(books[r]);
            }

            return randomBooks;

        }

    }
}
