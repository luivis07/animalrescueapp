using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.helpers.extensions;
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

            builder.Property(va => va.Username).HasMaxLength(250);
            builder.Property(va => va.FirstName).HasMaxLength(150);
            builder.Property(va => va.LastName).HasMaxLength(150);
            builder.Property(va => va.EmailAddress).HasMaxLength(255);
            builder.Property(va => va.PhoneNumber).HasMaxLength(150);
            builder.BuildAddress();
            builder.Property(va => va.DateOfBirth).HasColumnType("date");
            builder.Property(va => va.DogTrainingDetails).HasMaxLength(500);
            builder.Property(va => va.BottleFeedingDetails).HasMaxLength(500);
            builder.Property(va => va.GrantWritingDetails).HasMaxLength(500);
            builder.Property(va => va.ConvictedFelonyOfAnimalsDetails).HasMaxLength(500);
        }
    }
}