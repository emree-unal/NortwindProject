using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using YazılımKampıKatmanlıMimari.Business.Abstract;
using YazılımKampıKatmanlıMimari.Business.ValidationRules.FluentValidation;
using YazılımKampıKatmanlıMimari.Core.Aspects.Autofac.Validation;
using YazılımKampıKatmanlıMimari.Core.CrossCuttingConcerns.Validation;
using YazılımKampıKatmanlıMimari.DataAccess.Abstract;
using YazılımKampıKatmanlıMimari.Entities;
using YazılımKampıKatmanlıMimari.Core.Utilities.Results;
using YazılımKampıKatmanlıMimari.Business.Constants;
using YazılımKampıKatmanlıMimari.Business.BusinessAspects.Autofac;
using YazılımKampıKatmanlıMimari.Core.Aspects.Autofac.Caching;
using YazılımKampıKatmanlıMimari.Core.Aspects.Autofac.Transaction;
using YazılımKampıKatmanlıMimari.Core.Aspects.Autofac.Performance;

namespace YazılımKampıKatmanlıMimari.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Product product)
        {
           
                

            if (CheckIfProductCountOfCategoryCorrect(product.CategoryId))
            {
                if (CheckIfProductNameExists(product.ProductName))
                {
                    productDal.Add(product);
                    return new SuccessResult(Messages.ProductAdded);
                }
                else
                {
                    //throw new Exception("Bu ürün adı ile aynı olan bir ürün bulunmaktadır.");
                    return new ErrorResult(Messages.ProductNameExist);

                }
               
            }
            else
            {
                //throw new Exception("Kategorideki ürün sayısı fazla");
                return new ErrorResult(Messages.CategoryCountExceed);
            }



        }

        private bool CheckIfProductNameExists(string productName)
        {
            var result = productDal.GetAll(x => x.ProductName == productName).Any();
            if (result)
            {
                return true;
            }
            return false;
        }

        private bool CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var countOfProduct = productDal.GetAll(x => x.CategoryId == categoryId).Count;
            if (countOfProduct <= 10)
            {
                return true;
            }
            return false;
        }
      
        public IResult Delete(Product product)
        {
            productDal.Delete(product);
            return new Result(true,"Ürün silinmiştir.");
        }

        [CacheAspect]
        //[SecuredOperation("product.getall,admin")]
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour==22
                )
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(productDal.GetAll(),Messages.ProductListed);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(productDal.Get(x => x.ProductId == id));
        }

        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Product product)
        {
            productDal.Update(product);
            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Product product)
        {
            Add(product);
            if (product.UnitPrice<10)
            {
                throw new Exception("");
            }
            Add(product);
            return null;
        }
    }
}
