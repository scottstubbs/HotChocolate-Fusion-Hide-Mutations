namespace Cars.Types;

public class Owner
{
    public int Id { get; set; }
    public IEnumerable<Car> Cars { get; set; } = [];
}
