using animalrescue.mainmodule.dal.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.dal.entityconfigurations
{
    public class AnimalRescueAccountRoleConfiguration : IEntityTypeConfiguration<AnimalRescueAccountRole>
    {
        public void Configure(EntityTypeBuilder<AnimalRescueAccountRole> builder)
        {
            builder.HasKey(arar => new{arar.AnimalRescueAccountId,arar.RoleId});
        }
    }
}