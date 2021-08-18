using PCS.Extension.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCS.Extension.Data.Configuration
{
    public class ReponseDataConfiguration : IEntityTypeConfiguration<ResponseData>
    {
        public void Configure(EntityTypeBuilder<ResponseData> builder)
        {
            builder.ToTable("ReponseData");
            builder.HasKey(x => x.Id);
        }
    }
}
