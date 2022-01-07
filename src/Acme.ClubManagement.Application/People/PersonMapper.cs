using Acme.ClubManagement.Dates;
using Acme.ClubManagement.Domain;

namespace Acme.ClubManagement.People;

public static class PersonMapper
{
    public static Person MapToDomain(this PersonDto personDto)
    {
        if (personDto is null)
        {
            throw new ArgumentNullException(nameof(personDto));
        }

        var salutation = new Salutation();
        salutation.SetId(personDto.SalutationId);

        var dob = personDto.DateOfBirth.ToDateOnly();

        var person = Person.Create(
            salutation,
            personDto.GivenName,
            personDto.MiddleNames,
            personDto.Surname,
            dob);

        return person;
    }
}
