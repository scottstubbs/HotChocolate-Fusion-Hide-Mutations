using HotChocolate.Fusion.SourceSchema.Types;
using Owners.Types;

namespace Owners.Operations;

public static class OwnerOperations
{
    [Query]
    [Lookup]
    [Internal]
    public static Owner? GetOwnerById(int id)
    {
        return Repository.Owners.SingleOrDefault(owner => owner.Id == id);
    }

    [Query]
    [Lookup]
    [Internal]
    public static IEnumerable<Owner?> GetOwnersById([Is("id")] int[] ids)
    {
        var results = Repository.Owners.Where(owner => ids.Contains(owner.Id));
        return results;
    }
}
