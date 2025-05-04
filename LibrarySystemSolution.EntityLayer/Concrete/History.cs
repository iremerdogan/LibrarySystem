using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSolution.EntityLayer.Concrete
{
    public class History
    {
        [Key, Column(Order = 0)]
        public int Member_Id { get; set; }

        [Key, Column(Order = 1)]
        public int Book_Id { get; set; }

        [Key, Column(Order = 2)]
        public DateTime Loan_Date { get; set; }
        public DateTime Due_Date { get; set; }

        public virtual Member Member { get; set; }

        public virtual Book Book { get; set; }
    }
}
