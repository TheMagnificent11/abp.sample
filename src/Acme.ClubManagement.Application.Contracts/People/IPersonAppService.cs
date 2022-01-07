using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.ClubManagement.People;

public interface IPersonAppService :
    ICrudAppService<PersonDto, Guid, PagedAndSortedResultRequestDto, SavePersonRequest>
{
}
