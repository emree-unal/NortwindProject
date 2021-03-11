using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Core.Utilities.Results;
using YazılımKampıKatmanlıMimari.Entities;

namespace YazılımKampıKatmanlıMimari.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>>  GetAll();
        IDataResult<Product>  GetById(int id);
        IResult Delete(Product product);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);

    }
}
