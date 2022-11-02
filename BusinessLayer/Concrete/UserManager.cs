using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserRepository _user;

        public UserManager(IUserRepository user)
        {
            _user = user;
        }

        public User GetById(int id)
        {
            return _user.GetById(id);
        }

        public List<User> GetUsers()
        {
            return _user.Listele();
        }

        public void UserAdd(User p)
        {
            _user.Ekle(p);
        }

        public void UserDelete(User p)
        {
            _user.Sil(p);
        }

        public void UserUpdate(User p)
        {
            _user.Guncelle(p);
        }
    }
}
