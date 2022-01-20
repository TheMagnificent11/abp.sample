using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.ClubManagement.People;

public interface IPeopleAppService :
    ICrudAppService<PersonDto, Guid, PagedAndSortedResultRequestDto, SavePersonRequest>
{
}
