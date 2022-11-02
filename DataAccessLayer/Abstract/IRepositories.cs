using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepositories<T> where T : class
    {
        void Ekle(T p);
        int Sil(T p);
        int Guncelle(T p);
        List<T> Listele();
        T GetById(int id);
    }
}
