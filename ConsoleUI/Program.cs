using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var product in productManager.GetComputerDetail())
            {
                Console.WriteLine(product.ProductName + "/" +product.Gpu +"/"+ product.Cpu +"/"+ product.Capacity +"/"+product.Ram);
            }
            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}
        }
    }
}
