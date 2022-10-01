// See https://aka.ms/new-console-template for more information

using Lab03_belousov;

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new(1, 1, 2);
        Vector v2 = new(1, 1, 3);
        Console.WriteLine($"v1 < v2 is {v1 < v2}");
        Console.WriteLine($"v1 = ({v1.X}, {v1.Y}, {v1.Z})");
        Console.WriteLine($"v1 * 2 = ({(v1 * 2).X}, {(v1 * 2).Y}, {(v1 * 2).Z})");
        Console.WriteLine($"v1 * v2 = ({(v1 * v2).X}, {(v1 * v2).Y}, {(v1 * v2).Z})");
    }
}