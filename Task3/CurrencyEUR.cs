namespace Task3;

public class CurrencyEUR : Currency
{
    private static double _EUR_TO_RUB;
    private static double _EUR_TO_USD;
    private static double _USD_TO_RUB;
    
    public CurrencyEUR(double eurToRub, double eurToUsd, double usdToRub, double value) => 
        (_EUR_TO_RUB, _EUR_TO_USD, _USD_TO_RUB, Value) = (eurToRub, eurToUsd, usdToRub, value);

    public double Value { get; set; }

    public static implicit operator CurrencyRUB(CurrencyEUR eurs)
    {
        return new CurrencyRUB(1 / _EUR_TO_RUB, _USD_TO_RUB, 
            1 / _EUR_TO_USD,_EUR_TO_RUB * eurs.Value);
    }
    public static implicit operator CurrencyUSD(CurrencyEUR eurs)
    {
        return new CurrencyUSD(1 / _EUR_TO_USD, 1 / _USD_TO_RUB, 
            1 / _EUR_TO_USD, _EUR_TO_USD * eurs.Value);
    }
}