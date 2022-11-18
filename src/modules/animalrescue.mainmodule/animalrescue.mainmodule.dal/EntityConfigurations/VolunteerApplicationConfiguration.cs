using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class VolunteerApplicationConfiguration : IEntityTypeConfiguration<VolunteerApplication>
    {
        public void Configure(EntityTypeBuilder<VolunteerApplication> builder)
        {
            builder.HasOne<AnimalRescueAccount>(va => va.AnimalRescueAccount)
                .WithOne(ara => ara.VolunteerApplication)
                .HasForeignKey<VolunteerApplication>(va => va.AnimalRescueAccountId);

            builder.HasMany(va => va.VolunteerApplicationInterests)
                .WithOne(vai => vai.VolunteerApplication)
                .HasForeignKey(va => va.VolunteerApplicationId); 

            builder.HasMany(va => va.VolunteerApplicationPets)
                .WithOne(vap => vap.VolunteerApplication)
                .HasForeignKey(va => va.VolunteerApplicationId);     

            builder.HasMany(va => va.VolunteerApplicationPurposes)
                .WithOne(vau => vau.VolunteerApplication)
                .HasForeignKey(va => va.VolunteerApplicationId);

            builder.HasMany(va => va.VolunteerApplicationAgreements)
                .WithOne(vaa => vaa.VolunteerApplication)
                .HasForeignKey(va => va.VolunteerApplicationId);     
        }
    }
}