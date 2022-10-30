using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class AnimalRescueAccountLocationConfiguration : IEntityTypeConfiguration<AnimalRescueAccountLocation>
    {
        public void Configure(EntityTypeBuilder<AnimalRescueAccountLocation> builder)
        {
            builder.HasKey(aral => new{aral.AnimalRescueAccountId,aral.LocationId});
        }
    }
}