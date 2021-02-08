using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Entities
{
    public class ProductsCategory
    {
        public int ID { get; set; }
        public int ProductsID { get; set; }
        public products products { get; set; }
        public int categoryID { get; set; }
        public category category { get; set; }
    }
}
