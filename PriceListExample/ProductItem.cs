namespace PriceListExample
{
    public class ProductItem
    {
        public ProductItem(int id, string name, Price price)
        {
            Id = id;
            Name = name;
            ProductPrice = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Price ProductPrice { get; set; }
    }
}