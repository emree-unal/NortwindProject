using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using YazılımKampıKatmanlıMimari.Core.Entities;

namespace YazılımKampıKatmanlıMimari.Core.DataAcess
{
    public interface IEntityRepository<T> where T:class, IEntity , new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T TEntity);
        void Delete(T TEntity);
        void Update(T TEntity);
    }
}
