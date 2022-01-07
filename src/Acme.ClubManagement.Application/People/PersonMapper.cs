using Acme.ClubManagement.Dates;
using Acme.ClubManagement.Domain;

namespace Acme.ClubManagement.People;

public static class PersonMapper
{
    public static Person MapToDomain(this IPersonDto personDto)
    {
        if (personDto is null)
        {
            throw new ArgumentNullException(nameof(personDto));
        }

        var dob = personDto.DateOfBirth.ToDateOnly();

        var person = Person.Create(
            personDto.SalutationId,
            personDto.GivenName,
            personDto.MiddleNames,
            personDto.Surname,
            dob);

        return person;
    }
}
