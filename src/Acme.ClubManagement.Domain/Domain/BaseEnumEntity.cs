using Volo.Abp.Domain.Entities;

namespace Acme.ClubManagement.Domain;

public abstract class BaseEnumEntity<TKey> : Entity<TKey>, IEnumEntity<TKey>
    where TKey : struct, IConvertible, IComparable
{
    public string Name { get; protected set; }

    public void SetId(TKey id)
    {
        this.Id = id;
        this.Name = id.ToString();
    }
}
