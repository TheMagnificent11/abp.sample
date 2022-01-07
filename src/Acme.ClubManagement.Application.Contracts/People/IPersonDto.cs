using Acme.ClubManagement.Dates;
using Acme.ClubManagement.Enums;

namespace Acme.ClubManagement.People;

public interface IPersonDto
{
    string GivenName { get; set; }

    string MiddleNames { get; set; }

    string Surname { get; set; }

    SalutationType SalutationId { get; set; }

    DateDto DateOfBirth { get; set; }
}
