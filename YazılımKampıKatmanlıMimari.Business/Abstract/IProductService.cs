using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Entities;

namespace YazılımKampıKatmanlıMimari.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Delete(Product product);
        void Add(Product product);
        void Update(Product product);
    }
}
