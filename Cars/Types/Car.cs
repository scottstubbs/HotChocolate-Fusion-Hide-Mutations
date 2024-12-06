namespace Cars.Types;

public class Car
{
    public int Id { get; set; }
    public required string Make { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }
    public required string Color { get; set; }
    [GraphQLIgnore]
    public int OwnerId { get; set; }
    public Owner? GetOwner() => new() { Id = OwnerId };
}
