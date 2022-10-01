namespace Task3;

public class CurrencyRUB : Currency
{
    private static double _RUB_TO_EUR;
    private static double _RUB_TO_USD;
    private static double _EUR_TO_USD;

    public CurrencyRUB(double rubToEur, double rubToUsd, double eurToUsd, double value) =>
        (_RUB_TO_EUR, _RUB_TO_USD, _EUR_TO_USD, Value) = (rubToEur, rubToUsd, eurToUsd, value);
    public double Value { get; set; }

    public static implicit operator CurrencyUSD(CurrencyRUB rubs)
    {
        return new CurrencyUSD(1 / _EUR_TO_USD, 1 / _RUB_TO_USD, 
            1 / _RUB_TO_EUR, _RUB_TO_USD * rubs.Value);
    }

    public static implicit operator CurrencyEUR(CurrencyRUB rubs)
    {
        return new CurrencyEUR(1 / _RUB_TO_EUR, _EUR_TO_USD, 
            1 / _RUB_TO_USD, rubs.Value);
    }
}