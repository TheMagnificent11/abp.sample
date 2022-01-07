using FluentValidation;

namespace Acme.ClubManagement.Dates;

public sealed class DateDtoValidator : AbstractValidator<DateDto>
{
    public DateDtoValidator()
    {
        var longMonths = new List<int> { 1, 3, 5, 7, 8, 10, 12 };
        var shortMonths = new List<int> { 4, 6, 9, 11 };

        this.RuleFor(x => x.Year)
            .NotEmpty();

        this.RuleFor(x => x.Month)
            .InclusiveBetween(1, 12);

        this.RuleFor(x => x.Day)
            .InclusiveBetween(1, 31)
            .When(x => longMonths.Contains(x.Month));

        this.RuleFor(x => x.Day)
            .InclusiveBetween(1, 30)
            .When(x => shortMonths.Contains(x.Month));

        this.RuleFor(x => x.Day)
            .InclusiveBetween(1, 28)
            .When(x => x.Month == 2 && x.Year % 4 > 0);

        this.RuleFor(x => x.Day)
            .InclusiveBetween(1, 29)
            .When(x => x.Month == 2 && x.Year % 4 == 0);
    }
}
