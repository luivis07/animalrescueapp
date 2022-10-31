using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class AnimalRescueAccountFosterApplicationConfiguration : IEntityTypeConfiguration<AnimalRescueAccountFosterApplication>
    {
        public void Configure(EntityTypeBuilder<AnimalRescueAccountFosterApplication> builder)
        {
            builder.HasOne<AnimalRescueAccount>(arafp => arafp.AnimalRescueAccount)
                .WithOne(ara => ara.AnimalRescueAccountFosterApplication)
                .HasForeignKey<AnimalRescueAccountFosterApplication>(arafp => arafp.AnimalRescueAccountId);
        }
    }
}