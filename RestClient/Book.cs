using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient
{
    public class Book
    {
        /// <summary>
        /// Det ID vi bruger
        /// </summary>
        public int ID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
