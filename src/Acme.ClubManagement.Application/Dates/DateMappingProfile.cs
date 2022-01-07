using AutoMapper;

namespace Acme.ClubManagement.Dates;

public sealed class DateMappingProfile : Profile
{
    public DateMappingProfile()
    {
        this.CreateMap<DateOnly, DateDto>();

        this.CreateMap<DateDto, DateOnly>()
            .ConstructUsing(x => x.ToDateOnly());
    }
}
