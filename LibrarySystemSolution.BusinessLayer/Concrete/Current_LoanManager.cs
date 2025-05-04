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
    public class Current_LoanManager : ICurrent_LoanService
    {
        private readonly ICurrent_LoanDal _current_loan_dal;

        public Current_LoanManager(ICurrent_LoanDal current_loan_dal)
        {
            _current_loan_dal = current_loan_dal;
        }

        public void TAdd(Current_Loan entity)
        {
            _current_loan_dal.Add(entity);
        }

        public List<Current_Loan> TGetAll()
        {
            return _current_loan_dal.GetAll();
        }

        public Current_Loan TGetById(int id)
        {
            return _current_loan_dal.GetById(id);
        }

        public void TRemove(Current_Loan entity)
        {
            _current_loan_dal.Remove(entity);
        }

        public void TUpdate(Current_Loan entity)
        {
            _current_loan_dal.Update(entity);
        }
    }
}
