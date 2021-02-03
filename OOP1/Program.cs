using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;     
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnıtPrice = 500;
            product1.UnitsInStock = 3;

            //bu şekilde de tanımlanabilir
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnıtPrice = 35 };


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

       

        }
    }
}
