using Acme.ClubManagement.Domain;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.ClubManagement.People;

public class PeopleAppService :
    CrudAppService<Person, PersonDto, Guid, PagedAndSortedResultRequestDto, SavePersonRequest>,
    IPersonAppService
{
    public PeopleAppService(IRepository<Person, Guid> repository)
        : base(repository)
    {
    }
}
