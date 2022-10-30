using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class CalendarConfiguration : IEntityTypeConfiguration<Calendar>
    {
        public void Configure(EntityTypeBuilder<Calendar> builder)
        {
            builder.HasOne(c => c.CalendarType)
                .WithMany(ct => ct.Calendars)
                .HasForeignKey(c => c.CalendarTypeId);

            builder.HasOne(c => c.Location)
            .WithMany(lc => lc.Calendars)
            .HasForeignKey(c => c.LocationId);
        }
    }
}