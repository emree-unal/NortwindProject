using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Core.Entities;

namespace YazılımKampıKatmanlıMimari.Entities
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public Category Category { get; set; }


    }
}
