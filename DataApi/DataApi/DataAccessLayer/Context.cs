using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.DataAccessLayer
{
    public class Context: DbContext
    {
        public DbSet<Currency> Currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID = postgres;Password=postgres;Server=db;Port=5432;Database=mydb;Integrated Security=true;Pooling=true;");
            //"PostgreSQL": "User ID = postgres;Password=postgres;Server=localhost;Port=5432;Database=mydb;Integrated Security=true;Pooling=true;"
            //"PostgreSQL": "User ID = postgres;Password=postgres;Server=db;Port=5432;Database=mydb;Integrated Security=true;Pooling=true;"
        }

    }
}
