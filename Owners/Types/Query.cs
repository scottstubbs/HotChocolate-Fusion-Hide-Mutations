namespace Owners.Types;

[QueryType]
public static class Query
{
    public static IEnumerable<Owner> GetOwners() => Repository.Owners;
}
