using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystemSolution.EntityLayer.Concrete;

namespace LibrarySystemSolution.DataAccessLayer.Context
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Current_Loan> Current_Loans { get; set; }
    }
}
