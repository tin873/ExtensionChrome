using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PCS.Extension.Data.Entities;

namespace PCS.Extension.Data.Configuration
{
    public class ClientCardConfiguration : IEntityTypeConfiguration<ClientCard>
    {
        public void Configure(EntityTypeBuilder<ClientCard> builder)
        {
            builder.ToTable("ClientCards");
            builder.HasKey(x => x.ClientCardId);
        }
    }
}
