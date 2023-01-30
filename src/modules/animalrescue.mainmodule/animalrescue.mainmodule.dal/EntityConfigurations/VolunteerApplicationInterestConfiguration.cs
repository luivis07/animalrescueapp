using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class VolunteerApplicationInterestConfiguration : IEntityTypeConfiguration<VolunteerApplicationInterest>
    {
        public void Configure(EntityTypeBuilder<VolunteerApplicationInterest> builder)
        {
            builder.HasKey(vai => new{vai.VolunteerApplicationId,vai.ApplicationInterestId});
        }
    }
}