using animalrescue.mainmodule.dal.repositories.interfaces;
using animalrescue.mainmodule.services.dtos;
using animalrescue.mainmodule.services.handlers.interfaces;
using AutoMapper;

namespace animalrescue.mainmodule.services.handlers
{
    public class VolunteerApplicationHandler : IVolunteerApplicationHandler
    {
        private readonly IVolunteerApplicationRepository volunteerApplicationRepository;
        private readonly IMapper mapper;

        public VolunteerApplicationHandler(IVolunteerApplicationRepository volunteerApplicationRepository,
                                            IMapper mapper)
        {
            this.volunteerApplicationRepository = volunteerApplicationRepository;
            this.mapper = mapper;
        }

        public IEnumerable<VolunteerApplicationDto> GetVolunteerApplications()
        {
            var temp = volunteerApplicationRepository.GetVolunteerApplications();
            return mapper.Map<IEnumerable<VolunteerApplicationDto>>(temp);
        }
    }
}