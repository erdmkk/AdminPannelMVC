using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void UserAdd(User p);

        void UserUpdate(User p);

        void UserDelete(User p);

        List<User> GetUsers();

        User GetById(int id);
    }
}
