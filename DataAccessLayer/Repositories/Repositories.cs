using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Repositories<T> : IRepositories<T> where T : class
    {
        Context c = new Context();

        public void Ekle(T p)
        {
            c.Add(p);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public int Guncelle(T p)
        {
            c.Update(p);
            return c.SaveChanges();
        }

        public List<T> Listele()
        {
            return c.Set<T>().ToList();
        }

        public int Sil(T p)
        {
            c.Remove(p);
            return c.SaveChanges();
        }
    }
}
