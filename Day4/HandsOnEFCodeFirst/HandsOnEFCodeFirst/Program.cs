using System;
using HandsOnEFCodeFirst.Entities;
namespace HandsOnEFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            //Add Record
            Product p = new Product()
            {

                Pname = "Keyboard",
                Price=500,
                Stock=10
            };
           using(MyDbContext db=new MyDbContext())
            {
                db.Products.Add(p);
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
