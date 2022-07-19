using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    // Mesela product nesnelerini yazdırdığımız zaman yanında categoryName ini de görmek isteriz. 
    // Bu tip join gibi operasyonları DTO (Data Transformation Object) içine yazarız.
    //
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
