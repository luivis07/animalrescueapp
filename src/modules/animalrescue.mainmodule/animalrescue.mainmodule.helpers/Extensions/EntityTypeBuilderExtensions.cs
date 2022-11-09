using animalrescue.mainmodule.helpers.interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace animalrescue.mainmodule.helpers.extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static void BuildAddress<T>(this EntityTypeBuilder<T> entityTypeBuilder) where T : class, IHasAddress
        {
            entityTypeBuilder.Property(ara => ara.Address1).HasMaxLength(100);
            entityTypeBuilder.Property(ara => ara.Address2).HasMaxLength(60);
            entityTypeBuilder.Property(ara => ara.City).HasMaxLength(60);
            entityTypeBuilder.Property(ara => ara.State).HasMaxLength(50);
            entityTypeBuilder.Property(ara => ara.ZipCode).HasMaxLength(10);
            entityTypeBuilder.Property(ara => ara.Country).HasMaxLength(55);
        }
    }
}