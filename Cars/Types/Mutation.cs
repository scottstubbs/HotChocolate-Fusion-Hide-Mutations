using HotChocolate.Fusion.SourceSchema.Types;

namespace Cars.Types;

[MutationType]
public static class Mutation
{
    [Internal]
    public static Car CreateCar(string make, string model, int year, string color, int ownerId)
    {
        var car = new Car
        {
            Id = Repository.Cars.Max(c => c.Id) + 1,
            Make = make,
            Model = model,
            Year = year,
            Color = color,
            OwnerId = ownerId
        };
        Repository.Cars.Add(car);
        return car;
    }

    [Internal]
    public static Car UpdateCar(int id, string? make = null, string? model = null, int? year = null, string? color = null, int? ownerId = null)
    {
        var car = Repository.Cars.FirstOrDefault(c => c.Id == id);
        if (car == null)
        {
            throw new Exception("Car not found");
        }
        if (make != null)
        {
            car.Make = make;
        }
        if (model != null)
        {
            car.Model = model;
        }
        if (year.HasValue)
        {
            car.Year = year.Value;
        }
        if (color != null)
        {
            car.Color = color;
        }
        if (ownerId.HasValue)
        {
            car.OwnerId = ownerId.Value;
        }
        return car;
    }

    [Internal]
    public static bool DeleteCar(int id)
    {
        var car = Repository.Cars.FirstOrDefault(c => c.Id == id);
        if (car == null)
        {
            return false;
        }
        Repository.Cars.Remove(car);
        return true;
    }
}
