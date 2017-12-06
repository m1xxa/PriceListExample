namespace PriceListExample
{
    public class DbItemsProvider : IProductItemsProvider, IDbConfigurable
    {
        public ProductItem[] GetItems()
        {
            throw new System.NotImplementedException();
        }

        public void Configure(string[] properties)
        {
            throw new System.NotImplementedException();
        }
    }
}