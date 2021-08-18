using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PCS.Extension.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCS.Extension.Data.Configuration
{
    public class SourcePageConfiguration : IEntityTypeConfiguration<SourcePage>
    {
        public void Configure(EntityTypeBuilder<SourcePage> builder)
        {
            builder.ToTable("SourcePages");
            builder.HasKey(x => x.Id);
        }
    }
}
