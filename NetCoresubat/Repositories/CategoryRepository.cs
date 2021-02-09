using NetCoresubat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoresubat.Contexts;
using NetCoresubat.Interfaces;

namespace NetCoresubat.Repositories
{
    public class CategoryRepository: GenericRepository<category> , ICategoriesRepository
    {
        /// implement interfaces yapıldı. !!!!!!!!!!!!!!!!!!!!!1
        //public void Add(category tbl)
        //{
        //    using var context = new ProjectContext(); // using olmasının sebebi işlem tamamlandıktan sonra ramden silinmesini istemek.
        //    context.Categories.Add(tbl);
        //    context.SaveChanges();
        //}

        //public void Update(category tbl)
        //{
        //    using var context = new ProjectContext(); // using olmasının sebebi işlem tamamlandıktan sonra ramden silinmesini istemek.
        //    context.Update(tbl);
        //    context.SaveChanges();
        //}

        //public void Remove(category tbl)
        //{
        //    using var context = new ProjectContext(); // using olmasının sebebi işlem tamamlandıktan sonra ramden silinmesini istemek.
        //    context.Remove(tbl);
        //    context.SaveChanges();
        //}

        //public List<category> GetAllCategories(category tbl)
        //{
        //    using var context = new ProjectContext(); // using olmasının sebebi işlem tamamlandıktan sonra ramden silinmesini istemek.
        //    return context.Categories.OrderByDescending(u=>u.categoryID).ToList();

        //}

        //public category GetCategoriesByID(int id)
        //{
        //    using var context = new ProjectContext(); 
        //    return context.Categories.Find(id);

        //}
        //public void Add(category tbl)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<category> GetAll(category tbl)
        //{
        //    throw new NotImplementedException();
        //}

        //public object GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public category GetByID(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(category tbl)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(category tlb)
        //{
        //    throw new NotImplementedException();
        //}

        //List<category> IGenericRepository<category>.GetAll()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
