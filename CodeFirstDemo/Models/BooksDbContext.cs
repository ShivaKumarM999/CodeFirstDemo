using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class BooksDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
