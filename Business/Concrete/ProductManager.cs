using DataAcces.Abstruct;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return productDal.GetAll(p => p.CategoryID == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }
    }
}
