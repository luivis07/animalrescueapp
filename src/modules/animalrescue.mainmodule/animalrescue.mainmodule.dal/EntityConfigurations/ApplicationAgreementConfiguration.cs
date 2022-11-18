using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class ApplicationAgreementConfiguration : IEntityTypeConfiguration<ApplicationAgreement>
    {
        public void Configure(EntityTypeBuilder<ApplicationAgreement> builder)
        {
            builder.HasMany(aa => aa.VolunteerApplicationAgreements)
                .WithOne(vaa => vaa.ApplicationAgreement)
                .HasForeignKey(aa => aa.ApplicationAgreementId);
        }
    }
}