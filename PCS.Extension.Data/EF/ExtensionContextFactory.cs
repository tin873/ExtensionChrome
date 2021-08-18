using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PCS.Extension.Data.EF
{
    public class ExtensionContextFactory : IDesignTimeDbContextFactory<ExtensionContext>
    {
        public ExtensionContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Extension");

            var optionsBuilder = new DbContextOptionsBuilder<ExtensionContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ExtensionContext(optionsBuilder.Options);
        }
    }
    
}
