using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class AnimalRescueAccountAdoptionApplicationConfiguration : IEntityTypeConfiguration<AnimalRescueAccountAdoptionApplication>
    {
        public void Configure(EntityTypeBuilder<AnimalRescueAccountAdoptionApplication> builder)
        {
            builder.HasOne(araaa => araaa.AnimalRescueAccount)
                .WithMany(ara => ara.AnimalRescueAccountAdoptionApplications)
                .HasForeignKey(araaa => araaa.AnimalRescueAccountId);
        }
    }
}