using System.Collections.Generic;

public class Inventory
{
    private List<Product> products;

    public Inventory()
    {
        products = new List<Product>
        {
            new Product("Red Gogo's                  ", 2),
            new Product("Blue Gogo's                 ", 3),
            new Product("Green Transparent Gogo's    ", 5),
            new Product("Yellow Glitter Gogo's       ", 7),
            new Product("Gold Gogo's                 ", 10)
        };
    }

    public Product GetProduct(int index)
    {
        if (index >= 0 && index < products.Count)
            return products[index];

        return null;
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }
}