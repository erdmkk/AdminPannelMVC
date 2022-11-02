using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {

        IProductRepository _product;

        public ProductManager(IProductRepository product)
        {
            _product = product;
        }
      

        public Product GetById(int id)
        {
            return _product.GetById(id);
        }

        public List<Product> GetProducts()
        {
            return _product.Listele();
        }

        public void ProductAdd(Product p)
        {
            _product.Ekle(p);
        }

        public void ProductDelete(Product p)
        {
            _product.Sil(p);
        }

        public bool ProductUpdate(Product p)
        {
            int value = _product.Guncelle(p);
            if(value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
