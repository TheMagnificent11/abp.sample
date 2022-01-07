using Acme.ClubManagement.Domain;
using AutoMapper;

namespace Acme.ClubManagement.People;

public sealed class PersonMappingProfile : Profile
{
    public PersonMappingProfile()
    {
        this.CreateMap<Person, PersonDto>();

        this.CreateMap<PersonDto, Person>()
            .ConstructUsing(x => x.MapToDomain());
    }
}
