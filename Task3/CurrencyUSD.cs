namespace Task3;

public class CurrencyUSD : Currency
{
    private static double _USD_TO_EUR;
    private static double _USD_TO_RUB;
    private static double _EUR_TO_RUB;
    public CurrencyUSD(double usdToEur, double usdToRub, double eurToRub, double value) => 
        (_USD_TO_EUR, _USD_TO_RUB, _EUR_TO_RUB, Value) = (usdToEur, usdToRub, eurToRub, value);
    public double Value { get; set; }

    public static implicit operator CurrencyRUB(CurrencyUSD usds)
    {
        return new CurrencyRUB(1 / _EUR_TO_RUB, 1 / _USD_TO_RUB, 
            1 / _USD_TO_EUR, _USD_TO_RUB * usds.Value);
    }

    public static implicit operator CurrencyEUR(CurrencyUSD usds)
    {
        return new CurrencyEUR(_EUR_TO_RUB, 1 / _USD_TO_EUR,
            _USD_TO_RUB, _USD_TO_EUR * usds.Value);
    }
}