using Microsoft.EntityFrameworkCore;
using PCS.Extension.Data.Configuration;
using PCS.Extension.Data.Entities;

namespace PCS.Extension.Data.EF
{
    public class ExtensionContext:DbContext
    {
        public ExtensionContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppconfigConfiguration());

            //base.OnModelCreating(modelBuilder);

        }
        public DbSet<Products> Products { set; get; }
        public DbSet<Currency> Currencies { set; get; }
        public DbSet<SourcePage> SourcePages { set; get; }
        public DbSet<ClientCard> ClientCards { get; set; }
    }
}
