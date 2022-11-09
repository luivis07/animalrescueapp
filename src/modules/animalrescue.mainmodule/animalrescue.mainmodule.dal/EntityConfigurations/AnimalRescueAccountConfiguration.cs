using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.helpers.extensions;
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

            builder.Property(ara => ara.FirstName).HasMaxLength(150);
            builder.Property(ara => ara.LastName).HasMaxLength(150);
            builder.Property(ara => ara.EmailAddress).HasMaxLength(255);
            builder.Property(ara => ara.PhoneNumber).HasMaxLength(150);
            builder.BuildAddress();
            builder.Property(ara => ara.DateOfBirth).HasColumnType("date");
        }
    }
}