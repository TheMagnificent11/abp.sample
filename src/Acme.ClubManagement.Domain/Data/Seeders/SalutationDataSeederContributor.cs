using Acme.ClubManagement.Domain;
using Acme.ClubManagement.Enums;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.ClubManagement.Data.Seeders;

public sealed class SalutationDataSeederContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Salutation, SalutationType> repository;

    public SalutationDataSeederContributor(IRepository<Salutation, SalutationType> repository)
    {
        this.repository = repository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        var expectedData = EnumDataSeeder.GetEnumReferenceData<Salutation, SalutationType>();
        var existingData = await this.repository.GetListAsync();

        var newData = expectedData
            .Where(x => !existingData.Any(y => y.Id == x.Id))
            .ToArray();

        var dataToUpdate = expectedData
            .Where(x => existingData.Any(y => y.Id == x.Id && y.Name != x.Name))
            .ToArray();

        var dataToDelete = existingData
            .Where(x => !expectedData.Any(y => y.Id == x.Id))
            .ToArray();

        if (newData.Any())
        {
            await this.repository.InsertManyAsync(newData, autoSave: true);
        }

        if (dataToUpdate.Any())
        {
            await this.repository.UpdateManyAsync(dataToUpdate, autoSave: true);
        }

        if (dataToDelete.Any())
        {
            await this.repository.DeleteManyAsync(dataToDelete, autoSave: true);
        }
    }
}
