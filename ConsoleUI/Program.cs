using Business.Concrete;
using DataAcces.Concrete.EntityFremavork;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManagerTest();
           //ProductDetailsTest();
        }

        private static void ProductDetailsTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine
                        (
                            "Product Id :\t" + product.ProductId + "\n" +
                            "Product Name :\t" + product.ProductName + "\n" +
                            "Category Name :\t" + product.CategoryName + "\n" +
                            "Units In Stock :\t" + product.UnitsInStock + "\n" +
                            "-----------------------------------------------" + "\n"
                        );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ProductManagerTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            var result = productManager.GetAll();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine("Product Name :\t" + product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
