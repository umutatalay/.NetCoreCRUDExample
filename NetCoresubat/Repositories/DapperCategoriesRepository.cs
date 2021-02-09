using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using NetCoresubat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Repositories
{
    public class DapperCategoriesRepository
    {
        public List<category> GetAllProducts()
        {
            using var connection = new SqlConnection("server=DESKTOP-IT4752E; database=DbCoreProductsCategories; Integrated Security=True;");

            return connection.GetAll<category>().ToList();
        }
    }
}
