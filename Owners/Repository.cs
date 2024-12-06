using Owners.Types;

namespace Owners;

public static class Repository
{
    public static List<Owner> Owners { get; } =
    [
        new Owner
        {
            Id = 1,
            Name = "John Doe",
            Address = "123 Main St",
            City = "Anytown",
            State = "Anystate",
            Zip = "12345",
            Email = "john.doe@example.com",
            Phone = "555-1234"
        },
        new Owner
        {
            Id = 2,
            Name = "Jane Smith",
            Address = "456 Oak St",
            City = "Othertown",
            State = "Otherstate",
            Zip = "67890",
            Email = "jane.smith@example.com",
            Phone = "555-5678"
        },
        new Owner
        {
            Id = 3,
            Name = "Jim Brown",
            Address = "789 Pine St",
            City = "Sometown",
            State = "Somestate",
            Zip = "11223",
            Email = "jim.brown@example.com",
            Phone = "555-9012"
        }
    ];
}
