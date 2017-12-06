namespace PriceListExample
{
    public class Price
    {
        public Price(int value, int scale, string currency)
        {
            Value = value;
            Scale = scale;
            Currency = currency;
        }
        public int Value { get; set; }
        public int Scale { get; set; }
        public string Currency { get; set; }


    }
}