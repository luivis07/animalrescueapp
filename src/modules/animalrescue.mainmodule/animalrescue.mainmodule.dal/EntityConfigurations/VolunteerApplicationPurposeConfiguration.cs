using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class VolunteerApplicationPurposeConfiguration : IEntityTypeConfiguration<VolunteerApplicationPurpose>
    {
        public void Configure(EntityTypeBuilder<VolunteerApplicationPurpose> builder)
        {
            builder.HasKey(vap => new{vap.VolunteerApplicationId,vap.ApplicationPurposeId});
        }
    }
}