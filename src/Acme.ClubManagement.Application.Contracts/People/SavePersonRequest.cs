using Acme.ClubManagement.Dates;
using Acme.ClubManagement.Enums;

namespace Acme.ClubManagement.People;

public class SavePersonRequest
{
    public string GivenName { get; set; }

    public string MiddleNames { get; set; }

    public string Surname { get; set; }

    public SalutationType SalutationId { get; set; }

    public DateDto DateOfBirth { get; set; }
}