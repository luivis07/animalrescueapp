using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class ApplicationInterestConfiguration : IEntityTypeConfiguration<ApplicationInterest>
    {
        public void Configure(EntityTypeBuilder<ApplicationInterest> builder)
        {
            builder.HasMany(ai => ai.VolunteerApplicationInterests)
                .WithOne(vai => vai.ApplicationInterest)
                .HasForeignKey(ai => ai.ApplicationInterestId);

            builder.Property(ai => ai.Interest).HasMaxLength(100);             
        }
    }
}