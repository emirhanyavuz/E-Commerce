using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //OrderTest();

            //ProductManager productManager = new ProductManager(new EfProductDal());

            // var result = productManager.GetById(1);

            // Console.WriteLine(result.Data.ProductName);



            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);

            //}
            //Console.WriteLine(categoryManager.GetById(2).CategoryName);

            // }

            //private static void OrderTest()
            //{
            //    OrderManager ordermanager = new OrderManager(new EfOrderDal());


            //    foreach (var order in ordermanager.GetAllByCustomerId("VINET"))
            //    {
            //        Console.WriteLine("OrderId: " + order.OrderId + "  CustomerId: " + order.EmployeeId);

            //    }
            //}

            // private static void ProductTest()
            // {
            //roductManager productManager = new ProductManager(new EfProductDal());

            //var result = productManager.GetProductDetail();

            // if (result.Success)
            // {
            // foreach (var product in result.Data)
            // {
            // Console.WriteLine(product.ProductName + "/" + product.CategoryName);


            //}

            //}
            //else
            // {
            //Console.WriteLine(result.Message);
            // }




            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.ProductName);


            //}

            //foreach (var product in productManager.GetProductDetail().Data)
            //{
            //    Console.WriteLine(product.ProductName + " Category : " + product.CategoryName);

            //}
            // }
            //}
            // }
        }
    }
}
    


