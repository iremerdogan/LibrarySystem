using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystemSolution.BusinessLayer.Abstract;
using LibrarySystemSolution.DataAccessLayer.Abstract;
using LibrarySystemSolution.EntityLayer.Concrete;

namespace LibrarySystemSolution.BusinessLayer.Concrete
{
    public class HistoryManager : IHistoryService
    {
        private readonly IHistoryDal _historydal;

        public HistoryManager(IHistoryDal historydal)
        {
            _historydal = historydal;
        }

        public void TAdd(History entity)
        {
            _historydal.Add(entity);
        }

        public List<History> TGetAll()
        {
            return _historydal.GetAll();
        }

        public History TGetById(int id)
        {
            return _historydal.GetById(id);
        }

        public void TRemove(History entity)
        {
            _historydal.Remove(entity);
        }

        public void TUpdate(History entity)
        {
            _historydal.Update(entity);
        }
    }
}
