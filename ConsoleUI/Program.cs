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
            UserManager userManager = new UserManager(new EfUserDal());
            AdminManager adminManager = new AdminManager(new EfAdminDal());
            CardManager cardManager = new CardManager(new EfCardDal());
            OrderManager orderManager = new OrderManager(new EfOrderDal());


            foreach (var order in productManager.GetOrderDetailDtos().Data)
            {
                Console.WriteLine(order.OrderId +"/"+order.OrderDetailsId+"/"+order.ProductId +"/"+order.ProductName+"/" + order.Quantity+ "/" + order.ProductBrand+ "/" + order.ProductDescription+ "/" + order.ProductPrice);
            }
            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}
        }
    }
}
