using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Microsoft.EntityFrameworkCore;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();


        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAll();

            if (result.Success)
            {
                foreach (var p in result.Data)
                {
                    Console.WriteLine(p.product_name+" -- ");

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var p in categoryManager.GetAll())
            {
                Console.WriteLine(p.category_name);

            }
        }
    }
}

