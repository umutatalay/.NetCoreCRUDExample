using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Entities
{
    [Dapper.Contrib.Extensions.Table("products")]
    public class products
    {
        public int productsID { get; set; }

        [MaxLength(100)]
        public string productsName { get; set; }

        [MaxLength(250)]
        public string productsImage { get; set; }
        public decimal productsPrice { get; set; }

        public List<ProductsCategory> ProductsCategories { get; set; }
    }
}
