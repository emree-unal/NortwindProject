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
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }
           
        }
    }
}
