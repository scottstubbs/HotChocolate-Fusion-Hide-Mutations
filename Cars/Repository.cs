using Cars.Types;

namespace Cars;

public static class Repository
{
    public static List<Car> Cars { get; } = new List<Car>
    {
        new Car
        {
            Id = 1,
            Make = "Toyota",
            Model = "Camry",
            Year = 2020,
            Color = "Red",
            OwnerId = 1
        },
        new Car
        {
            Id = 2,
            Make = "Toyota",
            Model = "Sequoia",
            Year = 2020,
            Color = "White",
            OwnerId = 1
        },
        new Car
        {
            Id = 3,
            Make = "Honda",
            Model = "Civic",
            Year = 2019,
            Color = "Blue",
            OwnerId = 2
        },
        new Car
        {
            Id = 4,
            Make = "Ford",
            Model = "Mustang",
            Year = 2021,
            Color = "Black",
            OwnerId = 3
        }
    };
}
