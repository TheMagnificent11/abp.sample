using Acme.ClubManagement.Enums;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace Acme.ClubManagement.Domain;

public class Person : AuditedAggregateRoot<Guid>
{
    protected Person()
    {
    }

    public string GivenName { get; protected set; }

    public string MiddleNames { get; protected set; }

    public string Surname { get; protected set; }

    public SalutationType SalutationId { get; protected set; }

    public Salutation Salutation { get; protected set; }

    public DateOnly DateOfBirth { get; protected set; }

    public Guid? UserId { get; protected set; }

    public IdentityUser User { get; protected set; }

    public static Person Create(
        SalutationType salutationType,
        string givenName,
        string middleNames,
        string surname,
        DateOnly dateOfBirth)
    {
        if (givenName is null)
        {
            throw new ArgumentNullException(nameof(givenName));
        }

        if (surname is null)
        {
            throw new ArgumentNullException(nameof(surname));
        }

        return new Person
        {
            Id = Guid.NewGuid(),
            SalutationId = salutationType,
            GivenName = givenName,
            MiddleNames = middleNames,
            Surname = surname,
            DateOfBirth = dateOfBirth
        };
    }

    public void SetUser(IdentityUser user)
    {
        if (user is null)
        {
            throw new ArgumentNullException(nameof(user));
        }

        if (this.UserId == user.Id)
        {
            return;
        }

        this.UserId = user.Id;
        this.User = user;
    }

    public void RemoveUser()
    {
        if (this.UserId == null)
        {
            return;
        }

        this.User = null;
        this.UserId = null;
    }
}
