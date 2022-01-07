using Acme.ClubManagement.Dates;
using Acme.ClubManagement.Validation;
using FluentValidation;

namespace Acme.ClubManagement.People;

public sealed class SavePersonRequestValidator : AbstractValidator<SavePersonRequest>
{
    public SavePersonRequestValidator()
    {
        this.RuleFor(x => x.GivenName)
            .NotEmpty()
            .MaximumLength(PersonValidation.MaxLengths.GivenName);

        this.RuleFor(x => x.MiddleNames)
            .MaximumLength(PersonValidation.MaxLengths.MiddleNames);

        this.RuleFor(x => x.Surname)
            .NotEmpty()
            .MaximumLength(PersonValidation.MaxLengths.Surname);

        this.RuleFor(x => x.SalutationId)
            .IsInEnum();

        this.RuleFor(x => x.DateOfBirth)
            .SetValidator(new DateDtoValidator());
    }
}
