// See https://aka.ms/new-console-template for more information

using Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rub to eur: ");
        double RUB_TO_EUR = Convert.ToDouble(Console.ReadLine()); //0,019
        Console.WriteLine("Rub to usd: ");
        double RUB_TO_USD = Convert.ToDouble(Console.ReadLine()); //0,018
        Console.WriteLine("Eur to usd: ");
        double EUR_TO_USD = Convert.ToDouble(Console.ReadLine()); //1,02
        CurrencyUSD usds1 = new CurrencyUSD(1 / EUR_TO_USD, 1 / RUB_TO_USD, 
            1 / RUB_TO_EUR, 100);
        CurrencyEUR eur = usds1;
        Console.WriteLine($"{usds1.Value} dollar(-s) is {eur.Value} eur(-s)");
        CurrencyRUB rubs = new CurrencyRUB(RUB_TO_EUR, RUB_TO_USD, EUR_TO_USD, 60);
        CurrencyUSD usds2 = rubs;
        Console.WriteLine($"{usds2.Value} dollar(-s) is {rubs.Value} rub(-s)");
    }
}