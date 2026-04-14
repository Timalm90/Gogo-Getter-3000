using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public int Money { get; private set; }
    private List<string> purchases;

    public User(int startMoney)
    {
        Money = startMoney;
        purchases = new List<string>();
    }

    public bool SpendMoney(int amount)
    {
        if (Money >= amount)
        {
            Money -= amount;
            return true;
        }
        return false;
    }

    public void AddPurchase(string productName)
    {
        purchases.Add(productName);
    }

    public void ShowPurchases()
    {
        Console.WriteLine("Your Gogo's:");

        if (purchases.Count == 0)
        {
            Console.WriteLine("Nothing yet.");
            return;
        }

        foreach (var item in purchases)
        {
            Console.WriteLine("- " + item);
        }
    }

    public int GetTotalCount()
    {
        return purchases.Count;
    }

    public bool HasGold()
    {
        return purchases.Contains("Gold Gogo's");
    }

    public bool RemoveGold()
    {
        return purchases.Remove("Gold Gogo's");
    }

    public string GetAllItemsAsText()
    {
        return string.Join(", ", purchases);
    }
}