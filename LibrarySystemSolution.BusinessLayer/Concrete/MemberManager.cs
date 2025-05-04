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
    public class MemberManager : IMemberService
    {
        private readonly IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void TAdd(Member entity)
        {   
            if (entity.FirstName != "" && entity.FirstName.Length >= 3 && entity.Address != null && entity.LastName != "" && entity.FirstName.Length <= 30)
            {
                _memberDal.Add(entity);
            }
            else
            {
                //error message
            }
        }

        public List<Member> TGetAll()
        {
            return _memberDal.GetAll();
        }

        public Member TGetById(int id)
        {
            return _memberDal.GetById(id);
        }

        public void TRemove(Member entity)
        {
            _memberDal.Remove(entity);
        }

        public void TUpdate(Member entity)
        {
            if (entity.Address != "" && entity.FirstName.Length >= 3 && entity.Address != null && entity.LastName != "" && entity.FirstName.Length <= 30)
            { 
                _memberDal.Update(entity); 
            }
            else
            {
                //error message
            }
        }
    }
}
