using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSolution.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetAll();
        void TAdd(T entity);
        void TRemove(T entity);
        void TUpdate(T entity);
        T TGetById(int id);
    }
}
