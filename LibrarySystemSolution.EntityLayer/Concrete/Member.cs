using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSolution.EntityLayer.Concrete
{
    public class Member
    {
        [Key]
        public int Member_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Phone_Number { get; set; }
        public int Limit { get; set; }

        public List<History> History { get; set; }

        public List<Current_Loan> CurrentLoans { get; set; }
    }
}
