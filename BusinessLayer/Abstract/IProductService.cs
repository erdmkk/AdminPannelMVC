using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        void ProductAdd(Product p);

        bool ProductUpdate(Product p);

        void ProductDelete(Product p);

        List<Product> GetProducts();

        Product GetById(int id);
    }
}
