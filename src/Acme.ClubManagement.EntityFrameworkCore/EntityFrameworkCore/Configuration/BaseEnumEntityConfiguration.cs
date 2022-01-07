using Acme.ClubManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Acme.ClubManagement.EntityFrameworkCore.Configuration;

public abstract class BaseEnumEntityConfiguration<TEnum, TEnumEntity> : IEntityTypeConfiguration<TEnumEntity>
    where TEnum : struct, IConvertible, IComparable
    where TEnumEntity : class, IEnumEntity<TEnum>
{
    public virtual void Configure(EntityTypeBuilder<TEnumEntity> builder)
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.HasKey(i => i.Id);

        builder.Property(i => i.Id)
            .ValueGeneratedNever();

        builder.Property(i => i.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
