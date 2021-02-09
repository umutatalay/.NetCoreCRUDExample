using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using NetCoresubat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Repositories
{
    public class DProductsRepository
    {
        public List<products> GetAllProducts()
        {
            using var connection = new SqlConnection("server=DESKTOP-IT4752E; database=DbCoreProductsCategories; Integrated Security=True;");

            return connection.GetAll<products>().ToList();
        }
    }
}
