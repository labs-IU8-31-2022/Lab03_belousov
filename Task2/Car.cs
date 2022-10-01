namespace Task2;


public class Car : IEquatable<Car>
{
    public readonly string Name;
    public readonly string Engine;
    public readonly uint MaxSpeed;
    public Car(string name, string engine, uint maxSpeed) => (Name, Engine, MaxSpeed) = (name, engine, maxSpeed);
    public override string ToString() { return Name; }
    public bool Equals(Car other)
    {
        return this.Name == other.Name;
    }
}