using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Entities
{
    public class category
    {
        public int categoryID { get; set; }

        [MaxLength(100)]
        public string categoryName { get; set; }

        public List<ProductsCategory> ProductsCategories { get; set; }
    }
}
