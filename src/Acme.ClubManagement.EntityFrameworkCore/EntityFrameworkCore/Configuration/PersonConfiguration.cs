using Acme.ClubManagement.Domain;
using Acme.ClubManagement.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.ClubManagement.EntityFrameworkCore.Configuration;

public sealed class PersonConfiguration : BaseEntityConfiguration<Person, Guid>
{
    public override void Configure(EntityTypeBuilder<Person> builder)
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.ToTable("People");

        base.Configure(builder);

        builder.Property(x => x.GivenName)
            .IsRequired()
            .HasMaxLength(PersonValidation.MaxLengths.GivenName);

        builder.Property(x => x.MiddleNames)
            .HasMaxLength(PersonValidation.MaxLengths.MiddleNames);

        builder.Property(x => x.Surname)
            .IsRequired()
            .HasMaxLength(PersonValidation.MaxLengths.Surname);

        builder.HasOne(x => x.Salutation)
            .WithMany()
            .HasForeignKey(x => x.SalutationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
