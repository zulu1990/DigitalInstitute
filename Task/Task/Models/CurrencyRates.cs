namespace ExchangeRate.Models
{
    public class CurrencyRates
    {
        public Dictionary<string, double> Data { get; set; }

        public CurrencyRates(Dictionary<string, double> data)
        {
            Data = data;
        }
    }
}