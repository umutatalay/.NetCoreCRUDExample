using NetCoresubat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Repositories
{
    public class ProductsCategory : GenericRepository<ProductsCategory>, IProductCategoryRepository
    {
        public void Add(Entities.ProductsCategory tbl)
        {
            throw new NotImplementedException();
        }

        public void Remove(Entities.ProductsCategory tbl)
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.ProductsCategory tlb)
        {
            throw new NotImplementedException();
        }

        List<Entities.ProductsCategory> IGenericRepository<Entities.ProductsCategory>.GetAll()
        {
            throw new NotImplementedException();
        }

        Entities.ProductsCategory IGenericRepository<Entities.ProductsCategory>.GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
