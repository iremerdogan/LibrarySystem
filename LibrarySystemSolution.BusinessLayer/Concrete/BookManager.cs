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
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void TAdd(Book entity)
        {
            _bookDal.Add(entity);
        }

        public List<Book> TGetAll()
        {
            return _bookDal.GetAll();
        }

        public Book TGetById(int id)
        {
            return _bookDal.GetById(id);
        }

        public void TRemove(Book entity)
        {
            _bookDal.Remove(entity);
        }

        public void TUpdate(Book entity)
        {
            _bookDal.Update(entity);
        }
    }
}
