using DataAcces.Abstruct;
using Entities;
using Entitties.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //Bu class için global olduğu için .net projelerinde (_products) yazılır
        List<Product> _products;

        public InMemoryProductDal()
        {
            this._products = new List<Product>
            {
                new Product
                {
                    ProductID=1,
                    CategoryID=1,
                    ProductName="Bardak",
                    UnitPrice=15,
                    UnitsInStock=15
                },
                 new Product
                {
                    ProductID=2,
                    CategoryID=2,
                    ProductName="Kamera",
                    UnitPrice=1000,
                    UnitsInStock=5
                },
                  new Product
                {
                    ProductID=3,
                    CategoryID=3,
                    ProductName="Telefon",
                    UnitPrice=3000,
                    UnitsInStock=100
                },
                   new Product
                {
                    ProductID=4,
                    CategoryID=4,
                    ProductName="Klavye",
                    UnitPrice=500,
                    UnitsInStock=10
                },
                    new Product
                {
                    ProductID=5,
                    CategoryID=5,
                    ProductName="Fare",
                    UnitPrice=50,
                    UnitsInStock=1000
                }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        //Linq Kullan
        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault
                (
                    //for each yerine kullanılır
                    p => p.ProductID == product.ProductID
                );
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _products.Where(p => p.CategoryID == CategoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault
                (
                    //for each yerine kullanılır
                    //Gönderilen ürün ID sine sahip ürünü bulur 
                    p => p.ProductID == product.ProductID
                );
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
