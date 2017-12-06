namespace PriceListExample
{
    public class UsPriceFormatter : IPriceFormatter
    {
        public string Format(Price price)
        {
            return $"{price.Currency} {price.Value}.{price.Scale}";
        }
    }
}