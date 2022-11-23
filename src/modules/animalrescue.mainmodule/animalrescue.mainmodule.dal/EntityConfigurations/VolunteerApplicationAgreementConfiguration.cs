using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class VolunteerApplicationAgreementConfiguration : IEntityTypeConfiguration<VolunteerApplicationAgreement>
    {
        public void Configure(EntityTypeBuilder<VolunteerApplicationAgreement> builder)
        {
            builder.HasKey(vaa => new{vaa.VolunteerApplicationId,vaa.ApplicationAgreementId});
        }
    }
}