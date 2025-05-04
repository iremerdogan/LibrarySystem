using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystemSolution.DataAccessLayer.Abstract;
using LibrarySystemSolution.DataAccessLayer.Repositories;
using LibrarySystemSolution.EntityLayer.Concrete;

namespace LibrarySystemSolution.DataAccessLayer.EntityFramework
{
    public class EFHistoryDal: GenericRepository<History>, IHistoryDal
    {
    }
}
