using System;
using System.Collections.Generic;

namespace RestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWorker myWorker = new HttpWorker();

            Book newBook = new Book() { ID = 44, Title = "Fisk", Price = 999 };
            Book returnedBook = myWorker.PostBook(newBook).Result;

            Console.WriteLine("Ny bog ID: " + returnedBook.ID);
            Console.WriteLine();
            
            IEnumerable<Book> allBooks = myWorker.GetAllBooks().Result;

            foreach (Book myBook in allBooks)
            {
                Console.WriteLine("Book title: " + myBook.Title);
            }
        }
    }
}
