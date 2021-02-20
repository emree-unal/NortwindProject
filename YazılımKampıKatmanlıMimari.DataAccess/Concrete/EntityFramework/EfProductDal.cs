using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Core.DataAcess.EntityFramework;
using YazılımKampıKatmanlıMimari.DataAccess.Abstract;
using YazılımKampıKatmanlıMimari.Entities;

namespace YazılımKampıKatmanlıMimari.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
