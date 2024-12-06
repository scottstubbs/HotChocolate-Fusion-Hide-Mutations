namespace Cars.Types;

[QueryType]
public static class Query
{
    public static IEnumerable<Car> GetCars() => Repository.Cars;
}
