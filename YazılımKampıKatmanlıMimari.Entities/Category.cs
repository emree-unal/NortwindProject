using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Core.Entities;

namespace YazılımKampıKatmanlıMimari.Entities
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
