namespace Task2;

public class CarCatalog
{
    public readonly List<Car> _Cars;

    public CarCatalog(params Car[] cars)
    {
        _Cars = new List<Car>();
        foreach (var el in cars)
        {
            _Cars.Add(el);
        }
    }

    public string this[int index]
    {
        get
        {
            return $"Model: {_Cars[index].Name} \t Enige: {_Cars[index].Engine} \t Max speed: {_Cars[index].MaxSpeed}";
        }
    }
}