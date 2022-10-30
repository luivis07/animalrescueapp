using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class AnimalRescueAccountConfiguration : IEntityTypeConfiguration<AnimalRescueAccount>
    {
        public void Configure(EntityTypeBuilder<AnimalRescueAccount> builder)
        {
            builder.HasMany(ara => ara.AnimalRescueAccountRoles)
                .WithOne(arar => arar.AnimalRescueAccount)
                .HasForeignKey(ara => ara.AnimalRescueAccountId);

            builder.HasMany(ara => ara.AnimalRescueAccountLocations)
                .WithOne(aral => aral.AnimalRescueAccount)
                .HasForeignKey(ara => ara.AnimalRescueAccountId);
        }
    }
}