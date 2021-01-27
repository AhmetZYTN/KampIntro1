using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {  
            //PascalCase //camelCase
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500; // birim fiyatı
            product1.UnitInStock = 3;

            /// diğer bir kullanış şekli
            Product product2 = new Product {Id=2, UnitPrice=35, ProductName="kalem", UnitInStock=5, CategoryId=5 };

            ProductManeger productManeger = new ProductManeger();
            productManeger.Add();

            
        }
    }
}
