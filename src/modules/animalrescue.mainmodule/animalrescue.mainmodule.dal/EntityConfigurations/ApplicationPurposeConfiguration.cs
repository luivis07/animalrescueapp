using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class ApplicationPurposeConfiguration : IEntityTypeConfiguration<ApplicationPurpose>
    {
        public void Configure(EntityTypeBuilder<ApplicationPurpose> builder)
        {
            builder.HasMany(ap => ap.VolunteerApplicationPurposes)
                .WithOne(vap => vap.ApplicationPurpose)
                .HasForeignKey(ap => ap.ApplicationPurposeId);
        }
    }
}