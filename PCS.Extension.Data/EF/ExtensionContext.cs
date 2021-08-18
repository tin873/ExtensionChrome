using PCS.Extension.Data.Configuration;
using PCS.Extension.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
        public DbSet<ResponseData> ReponseDataDbSet { set; get; }
        public DbSet<Currency> Currencies { set; get; }
        public DbSet<SourcePage> SourcePages { set; get; }
    }
}
