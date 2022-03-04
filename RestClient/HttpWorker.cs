using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace RestClient
{
    class HttpWorker
    {
        private string BookUrl = "http://localhost:9706/mitsuperapi/books";

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            IEnumerable<Book> allBooks = null;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(BookUrl);
                allBooks = await response.Content.ReadFromJsonAsync<IEnumerable<Book>>();
            }

            return allBooks;
        }

        public async Task<Book> PostBook(Book newBook)
        {
            using (HttpClient client = new HttpClient())
            {
                JsonContent serializedItem = JsonContent.Create(newBook);
                HttpResponseMessage response = await 
                    client.PostAsync(BookUrl, serializedItem);
                return await response.Content.ReadFromJsonAsync<Book>();
            }
        }
    }
}
