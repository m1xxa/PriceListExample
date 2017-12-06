using System;

namespace PriceListExample
{
    public interface IDbConfigurable
    {
        void Configure(String[] properties);
    }
}