using animalrescue.mainmodule.dal.models;
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
        }
    }
}