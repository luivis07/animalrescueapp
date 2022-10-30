using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class AnimalRescueAccountVolunteerApplicationConfiguration : IEntityTypeConfiguration<AnimalRescueAccountVolunteerApplication>
    {
        public void Configure(EntityTypeBuilder<AnimalRescueAccountVolunteerApplication> builder)
        {
            builder.HasOne<AnimalRescueAccount>(aravp => aravp.AnimalRescueAccount)
                .WithOne(ara => ara.AnimalRescueAccountVolunteerApplication)
                .HasForeignKey<AnimalRescueAccountVolunteerApplication>(aravp => aravp.AnimalRescueAccountId);
        }
    }
}