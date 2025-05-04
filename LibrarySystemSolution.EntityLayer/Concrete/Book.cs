using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSolution.EntityLayer.Concrete
{
    public class Book
    {

        [Key]
        public int Book_Id { get; set; }
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Publish_Year { get; set; }
        public string Category { get; set; }

        public List<History> History { get; set; }
        public List<Current_Loan> CurrentLoans { get; set; }
    }
}
