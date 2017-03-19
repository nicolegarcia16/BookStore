using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookModel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int isbnNumber { get; set; }
        public double price { get; set; }
    }
}
