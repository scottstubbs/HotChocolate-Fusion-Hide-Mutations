namespace Owners.Types;

[MutationType]
public static class Mutation
{
    public static Owner CreateOwner(string name, string email, string? address, string? city, string? state, string? zip, string? phone)
    {
        var owner = new Owner
        {
            Id = Repository.Owners.Max(o => o.Id) + 1,
            Name = name,
            Email = email,
            Address = address,
            City = city,
            State = state,
            Zip = zip,
            Phone = phone
        };
        Repository.Owners.Add(owner);
        return owner;
    }

    public static Owner UpdateOwner(int id, string? name = null, string? email = null, string? address = null, string? city = null, string? state = null, string? zip = null, string? phone = null)
    {
        var owner = Repository.Owners.FirstOrDefault(o => o.Id == id);
        if (owner == null)
        {
            throw new Exception("Owner not found");
        }
        if (name != null)
        {
            owner.Name = name;
        }
        if (email != null)
        {
            owner.Email = email;
        }
        if (address != null)
        {
            owner.Address = address;
        }
        if (city != null)
        {
            owner.City = city;
        }
        if (state != null)
        {
            owner.State = state;
        }
        if (zip != null)
        {
            owner.Zip = zip;
        }
        if (phone != null)
        {
            owner.Phone = phone;
        }
        return owner;
    }

    public static bool DeleteOwner(int id)
    {
        var owner = Repository.Owners.FirstOrDefault(o => o.Id == id);
        if (owner == null)
        {
            return false;
        }
        Repository.Owners.Remove(owner);
        return true;
    }
}
