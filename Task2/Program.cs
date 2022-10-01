// See https://aka.ms/new-console-template for more information

using Task2;

class Program
{
    static void Main(string[] args)
    {
        Car c1 = new Car("NISSAN GT-R", "VR38DETT", 320);
        Car c2 = new Car("Chevrolet Impala SS(1967)", "427 CID Turbo Jet V8", 215);
        CarCatalog catalog = new CarCatalog(c1, c2);
        Console.WriteLine($"c1 < c2 is {c1 == c2}");
        for(int i = 0; i < catalog._Cars.Count; ++i)
        {
            Console.WriteLine(catalog[i]);
        }
    }
}