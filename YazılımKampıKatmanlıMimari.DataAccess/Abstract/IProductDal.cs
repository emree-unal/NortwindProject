using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Core.DataAcess;
using YazılımKampıKatmanlıMimari.Entities;

namespace YazılımKampıKatmanlıMimari.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
