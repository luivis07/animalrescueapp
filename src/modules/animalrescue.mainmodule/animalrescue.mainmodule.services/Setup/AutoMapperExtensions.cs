using animalrescue.mainmodule.dal.setup;
using AutoMapper;

namespace animalrescue.mainmodule.services.setup
{
    public static class AutoMapperExtensions
    {
        public static void AddServiceProfiles(this IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.AddDalProfiles();
        }
    }
}