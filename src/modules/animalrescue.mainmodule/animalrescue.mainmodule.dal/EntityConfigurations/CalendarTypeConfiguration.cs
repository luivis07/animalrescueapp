using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class CalendarTypeConfiguration : IEntityTypeConfiguration<CalendarType>
    {
        public void Configure(EntityTypeBuilder<CalendarType> builder)
        {
            builder.Property(ct => ct.IsActive).HasDefaultValue(true);
        }
    }
}