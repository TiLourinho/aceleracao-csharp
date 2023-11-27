namespace Exemplos;

public class Rocket
{
    public string? Name { get; set; }
    public decimal Price { get; set; }

    int _fuel;
    readonly int _maxFuel = 5000;

    public int FuelAsPercentage
    {
        get => _fuel * 100 / _maxFuel;
        set
        {
            if (value > 100 || value < 0)
                throw new ArgumentOutOfRangeException(_fuel.ToString(), "Value must be between 0 and 100");

            _fuel = value * _maxFuel / 100;
        }
    }

    public Rocket(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}
