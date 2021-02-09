using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Interfaces
{
    public interface IGenericRepository<Tbl> where Tbl: class , new()
    {
        void Add(Tbl tbl);
        void Remove(Tbl tbl);
        void Update(Tbl tlb);
        public List<Tbl> GetAll();
        public Tbl GetByID(int id);

    }
}
