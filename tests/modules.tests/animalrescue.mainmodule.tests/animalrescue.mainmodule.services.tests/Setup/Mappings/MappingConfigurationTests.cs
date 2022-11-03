using animalrescue.mainmodule.web.setup;
using AutoMapper;

namespace animalrescue.mainmodule.services.tests.setup.mappings
{
    public class MappingConfigurationTests
    {
        [Fact]
        public void AutoMapperConfiguration_IsValid()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfiles();
            });
            config.AssertConfigurationIsValid();
        }
    }
}