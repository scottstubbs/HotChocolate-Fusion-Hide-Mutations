using Cars.Types;
using HotChocolate.Fusion.SourceSchema.Types;

namespace Cars.Operations;

public static class CarOperations
{
    [Query]
    [Lookup]
    [Internal]
    public static Owner GetOwnerById(int id)
    {
        var owner = new Owner
        {
            Id = id,
            Cars = Repository.Cars.Where(owner => owner.Id == id)
        };
        return owner;
    }

    [Query]
    [Lookup]
    [Internal]
    public static IEnumerable<Owner> GetOwnersById([Is("id")] int[] ids)
    {
        var owners = Repository.Cars
            .Where(car => ids.Contains(car.OwnerId))
            .GroupBy(car => car.OwnerId)
            .Select(group => new Owner
            {
                Id = group.Key,
                Cars = group
            });
        return owners;
    }
}
