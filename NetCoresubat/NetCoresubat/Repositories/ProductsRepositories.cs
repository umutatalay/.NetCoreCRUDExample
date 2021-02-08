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
       
    }
}
