using ProductSaleModel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSaleModel.Model
{
    public class Product : BaseEntity
    {
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ProductCategory ProductCategory { get; set; }

    }
}
