using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Edumaq.DataAccess.Models
{
    public class EdumaqDBContext:DbContext
    {
        public EdumaqDBContext(DbContextOptions<EdumaqDBContext> options): base(options)
        {
           
        }

        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder) 
        {

            
            
        }

        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<SupplierType> SupplierTypes { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ProductBundle> ProductBundles{ get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }


    }
}
