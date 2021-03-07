using System;
using YazılımKampıKatmanlıMimari.Business.Concrete;
using YazılımKampıKatmanlıMimari.DataAccess.Concrete.EntityFramework;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetAll();
            if (result.Success)
            {
                foreach (var item in productManager.GetAll().Data)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
           
        }
    }
}
