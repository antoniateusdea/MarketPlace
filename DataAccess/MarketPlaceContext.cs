using DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MarketPlaceContext : DbContext
    {
        public MarketPlaceContext()
        {
        }
        public MarketPlaceContext(DbContextOptions<MarketPlaceContext>
       options) : base(options)
        {
        }
              
        
        
       

        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost\\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog =MarketPlaceData; TrustServerCertificate = True")
            .LogTo(Console.WriteLine, new[] {
DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
            .EnableSensitiveDataLogging();
        }

        private void localhost(SqlServerDbContextOptionsBuilder builder)
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>()
 .HasMany(s => s.Customers)
 .WithMany(b => b.Stores)
 .UsingEntity<StoreCustomer>
 (bs => bs.HasOne<Customer>().WithMany(),
 bs => bs.HasOne<Store>().WithMany())
 .Property(bs => bs.DateJoined)
 .HasDefaultValueSql("getdate()");
        }
    }

}
