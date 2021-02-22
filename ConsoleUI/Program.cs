using Business.Concrete;
using DataAcces.Concrete.EntityFremavork;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new  EFProductDal());

            int counter = 0;
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("Product Name :\t" + product.ProductName );
                counter += 1;
            }

            Console.WriteLine("Toplam Ürün Sayısı :\t" + counter);
        }
    }
}
