using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22Day17
{
    public class BookClass
    {
        public int BookId;
        string Title;
        string author;
        string gener;
        string isAvailable;

        public BookClass(int BookId,string title,string author,string gener,string isAvailable)
        {
            this.BookId = BookId;
            this.Title = title;
            this.author = author;
            this.gener = gener;
            this.isAvailable = isAvailable;

        }
        
    }
}
