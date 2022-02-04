using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestApplication.Domain.Entities;

namespace TestApplication.Data.Configurations
{
    internal class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Username).HasMaxLength(100).IsRequired();

            builder.HasData(new UserEntity[]
            {
                new()
                {
                    Id = Guid.Parse("037870F4-1087-47D8-8DC7-CFECAA19A6AC"),
                    Username = "Hash"
                },
                new()
                {
                    Id = Guid.Parse("67FB9AAD-E0F5-45A6-9A2D-8686E0E07FEC"),
                    Username = "Denis"
                }
            });
        }
    }
}