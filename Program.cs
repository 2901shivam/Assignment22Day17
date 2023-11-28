using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22Day17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryClass lib = new LibraryClass();
            lib.Add(1, "The Catcher in the Rye", "J.D. Salinger", "Fiction", "Available");
            lib.Add(2, "To Kill a Mockingbird", "Harper Lee", "Fiction", "Available");
            lib.Add(3, "1984", "George Orwell", "Dystopian", "Available");
            Console.WriteLine("Welcome to Library");
            Console.WriteLine("Enter\n 1 Adding Books\n 2.View All the books present in the Library \n 3.Search a book by its id \n 4.Search a book by its title");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the bookId");
                        int bookid=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the title");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the author name");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter the gener");
                        string gener = Console.ReadLine();
                        Console.WriteLine("Is Available");
                        string isav = Console.ReadLine();
                        lib.Add(bookid, title, author, gener, isav);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("List of all the books present in tthe Library");
                        lib.ViewBooks();
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Book serching from its id");
                        Console.WriteLine("Enter the book id");
                        int id = int.Parse(Console.ReadLine());
                        lib.SearchById(id);
                        break;
                    }
                case 4:
                    {

                        Console.WriteLine("Book serching from its title");
                        Console.WriteLine("Enter the book title");
                        string title = Console.ReadLine();
                        lib.SearchByTitlt(title);

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Operation");
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}
