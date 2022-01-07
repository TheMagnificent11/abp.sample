namespace Acme.ClubManagement.Dates;

public static class DateDtoExtensions
{
    public static DateOnly ToDateOnly(this DateDto dateDto)
    {
        if (dateDto is null)
        {
            throw new ArgumentNullException(nameof(dateDto));
        }

        return new DateOnly(dateDto.Year, dateDto.Month, dateDto.Day);
    }
}
