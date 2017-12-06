namespace PriceListExample
{
    public class UaPriceFormatter : IPriceFormatter
    {
        public string Format(Price price)
        {
            return $"{price.Value},{price.Scale} {price.Currency}";
        }
    }
}