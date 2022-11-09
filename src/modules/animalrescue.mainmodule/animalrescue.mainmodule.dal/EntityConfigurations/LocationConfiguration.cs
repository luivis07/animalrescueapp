using animalrescue.mainmodule.dal.models;
using animalrescue.mainmodule.helpers.extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasMany(l => l.AnimalRescueAccountLocations)
                .WithOne(aral => aral.Location)
                .HasForeignKey(l => l.LocationId);
            builder.Property(l => l.PhoneNumber).HasMaxLength(150);
            builder.Property(l => l.IsActive).HasDefaultValue(true);
            builder.BuildAddress();    
        }
    }
}