using System;

public class VendingMachine
{
    private Inventory inventory;

    public VendingMachine(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void ShowProducts()
    {
        var products = inventory.GetAllProducts();

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {products[i].Name,-20} ${products[i].Price}");
        }
    }

    public void BuyProduct(int choice, User user)
    {
        Product? product = inventory.GetProduct(choice - 1);

        if (product == null)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        if (user.SpendMoney(product.Price))
        {
            user.AddPurchase(product.Name.Trim());
            Console.WriteLine($"You bought {product.Name.Trim()}!");
        }
        else
        {
            Console.WriteLine("Not enough money.");
        }
    }
}