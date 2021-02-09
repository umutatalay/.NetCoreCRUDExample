using NetCoresubat.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Repositories
{
    public class GenericRepository<Tbl> where Tbl: class, new()
    {
        public void Add(Tbl tbl)
        {
            using var context = new ProjectContext(); // using olmasının sebebi işlem tamamlandıktan sonra ramden silinmesini istemek.
            context.Set<Tbl>().Add(tbl);
            context.SaveChanges();
        }

        public void Update(Tbl tbl)
        {
            using var context = new ProjectContext(); // using olmasının sebebi işlem tamamlandıktan sonra ramden silinmesini istemek.
            context.Set<Tbl>().Update(tbl);
            context.SaveChanges();
        }

        public void Remove(Tbl tbl)
        {
            using var context = new ProjectContext(); // using olmasının sebebi işlem tamamlandıktan sonra ramden silinmesini istemek.
            context.Set<Tbl>().Remove(tbl);
            context.SaveChanges();
        }

        public List<Tbl> GetAll()
        {
            using var context = new ProjectContext(); // using olmasının sebebi işlem tamamlandıktan sonra ramden silinmesini istemek.
            return context.Set<Tbl>().ToList();

        }

        public Tbl GetByID(int id)
        {
            using var context = new ProjectContext();
            return context.Set<Tbl>().Find(id);

        }
    }
}
