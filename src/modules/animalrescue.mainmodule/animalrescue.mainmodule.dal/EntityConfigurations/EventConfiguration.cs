using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasOne(e => e.Calendar)
                .WithMany(c => c.Events)    
                .HasForeignKey(e => e.CalendarId);
        }
    }
}