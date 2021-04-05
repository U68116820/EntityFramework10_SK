using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EntityFramework_Assignment
{
    class product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal weight { get; set; }

        public List<ordered_products> ordered_productorder { get; set; }

    }
    class orders
    {
        public int Id { get; set; }
        public decimal billamount { get; set; }
        public decimal price { get; set; }
        public List<ordered_products> ordered_productproduct  { get; set; }
    }

    class ordered_products
    {
        public int ordered_productorderID { get; set; }
        public int ordered_productproductID { get; set; }
        
    }

    class storesellscontext : DbContext
    {
        public DbSet<product> product { get; set; }
        public DbSet<orders> orders { get; set; }
        public Dbset<ordered_products> ordered_products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
