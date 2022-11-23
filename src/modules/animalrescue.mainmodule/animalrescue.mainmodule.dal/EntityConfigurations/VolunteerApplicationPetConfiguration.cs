using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.helpers.extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class VolunteerApplicationPetConfiguration : IEntityTypeConfiguration<VolunteerApplicationPet>
    {
        public void Configure(EntityTypeBuilder<VolunteerApplicationPet> builder)
        {
            builder.HasOne(vap => vap.PetType)
                .WithMany(pt => pt.VolunteerApplicationPets)
                .HasForeignKey(vap => vap.PetTypeId);

            builder.BuildPet();   
        }
    }
}