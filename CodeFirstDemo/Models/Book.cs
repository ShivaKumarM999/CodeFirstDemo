using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public string Publisher { get; set; }

    }
}