using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamaya yarıyor.
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Hangi veri tabanıyla ilişkili belirttiğimiz bölüm
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");//Case insensitive //Sql server kullanacağız. Bu servera nasıl bağlanacağını belirttiğimiz bölüm.
        }
        public DbSet<Product> Products { get; set; } //Hangi class hangi tabloya karşılık gelecek.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

