using Acme.ClubManagement.Domain;

namespace Acme.ClubManagement.Data.Seeders;

public static class EnumDataSeeder
{
    public static TRefData[] GetEnumReferenceData<TRefData, TEnum>()
        where TRefData : BaseEnumEntity<TEnum>, new()
        where TEnum : struct, IConvertible, IComparable
    {
        var result = new List<TRefData>();

        foreach (TEnum item in Enum.GetValues(typeof(TEnum)))
        {
            var enumVal = (int)(object)item;

            if (enumVal == 0)
            {
                continue;
            }

            var data = new TRefData();
            data.SetId(item);

            result.Add(data);
        }

        return result.ToArray();
    }
}
