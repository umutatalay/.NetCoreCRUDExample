using NetCoresubat.Contexts;
using NetCoresubat.Entities;
using NetCoresubat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Repositories
{
    public class ProductsRepositories:GenericRepository<products>,IProductRepository
    {
        //public List<category> GetCategory(int p_id)
        //{
        //    using var context = new ProjectContext();
        //    context.Products.Join(context.ProductsCategory, products => products.productsID, ProductsCategory => ProductsCategory.ProductsID, (p, pc) => new
        //    {
        //        products = p,
        //        ProductsCategory=pc,
                
        //    }
        //    ).Join(context.Categories,tt=>tt.ProductsCategory.categoryID,category=>category.categoryID());
        //}
       
    }
}
