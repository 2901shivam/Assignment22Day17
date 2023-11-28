using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22Day17
{
    public class LibraryClass
    {
       

          List<BookClass>books = new List<BookClass>();
       

        public  void Add(int bookid,string title,string author,string gener,string isavialable) {

            BookClass book1 = new BookClass(bookid, title, author, gener, isavialable);
            books.Add(book1);
            
        }

        public  void ViewBooks()
        {
            foreach(BookClass book in books)
            {
                Console.WriteLine(book);
            }
        }
        public  void SearchById(int bookId)
        {
          foreach(BookClass book in books)
            {
                if (book.BookId.Equals(bookId))
                {
                    Console.WriteLine(book);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
        public  void SearchByTitlt(string title)
        {
            foreach(BookClass book in books)
            {
                if (book.Equals(title))
                {
                    Console.WriteLine(book);
                }
                else
                {
                    Console.WriteLine("Book is not found");
                }
            }

        }


    }
}
