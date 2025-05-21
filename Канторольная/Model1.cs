using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Канторольная
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AccessoriesToBoat> AccessoriesToBoat { get; set; }
        public virtual DbSet<Accessory> Accessory { get; set; }
        public virtual DbSet<Boat> Boat { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<Sales_Person> Sales_Person { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accessory>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Boat>()
                .Property(e => e.BasePrice)
                .HasPrecision(19, 4);
        }
    }
}
