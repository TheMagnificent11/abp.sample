namespace Acme.ClubManagement.Domain;

public interface IEnumEntity<TKey>
    where TKey : struct, IConvertible, IComparable
{
    TKey Id { get; }

    string Name { get; }
}
