using AutoMapper;
using Entities.Model;
using Shared.DataTransferObjects;

namespace CompanyEmployees.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Company, CompanyDto>()
            .ForCtorParam("FullAddress", opt => 
                opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
    }
}