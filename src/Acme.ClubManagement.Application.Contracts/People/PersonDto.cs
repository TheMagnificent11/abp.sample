using Acme.ClubManagement.Dates;
using Acme.ClubManagement.Enums;
using Volo.Abp.Application.Dtos;

namespace Acme.ClubManagement.People;

public class PersonDto : AuditedEntityDto<Guid>, IPersonDto
{
    public string GivenName { get; set; }

    public string MiddleNames { get; set; }

    public string Surname { get; set; }

    public SalutationType SalutationId { get; set; }

    public DateDto DateOfBirth { get; set; }
}
