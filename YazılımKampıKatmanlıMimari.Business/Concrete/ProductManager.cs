using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Business.Abstract;
using YazılımKampıKatmanlıMimari.Business.ValidationRules.FluentValidation;
using YazılımKampıKatmanlıMimari.Core.Aspects.Autofac.Validation;
using YazılımKampıKatmanlıMimari.Core.CrossCuttingConcerns.Validation;
using YazılımKampıKatmanlıMimari.DataAccess.Abstract;
using YazılımKampıKatmanlıMimari.Entities;

namespace YazılımKampıKatmanlıMimari.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public void Add(Product product)
        {
            
            productDal.Add(product);
        }

        public void Delete(Product product)
        {
            productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return productDal.Get(x => x.ProductId == id);
        }

        public void Update(Product product)
        {
            productDal.Update(product);
        }
    }
}
