using System;
using System.Collections.Generic;
using System.Linq;

namespace Marigolds.Consoleapp
{
    public class Marigolds
    {
        public List<MenuItem> menu = new()
        {
            new("Burger", 3.00M),
            new("Fries", 1.50M),
            new("Soda", 1.00M),
        };
        public List<Order> orders = new();
    
    public void PrintMenu(List<MenuItem> menu)
    {
      Console.WriteLine("What would you like from our menu?");
      for (int i = 0; i < menu.Count; i++)
      {
        Console.WriteLine($"{i + 1}: {menu[i].Product} (${menu[i].Price})");
      }

      Console.WriteLine();
    }

    public MenuItem InputItem(List<MenuItem> menu)
    {
      while (true)
      {
        Console.Write($"Enter option: 1, 2, or 3: ");
        if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= menu.Count)
        {
          Console.WriteLine($"You have picked: {menu[i - 1].Product}.\n");
          return menu[i - 1];
        }
        
        Console.WriteLine("That is not in our menu.\n");
      }
    }

    public int InputQuantity()
    {
      while (true)
      {
        Console.Write("Enter quantity: ");
        if (int.TryParse(Console.ReadLine(), out int i) && i > 0)
        {
          return i;
        }

        Console.WriteLine("Invalid quantity.\n");
      }
    }

    public void PrintSubTotal(List<Order> orders)
    {
      Console.WriteLine($"Your Subtotal: ${orders.Sum(o => o.Item.Price * o.Quantity)}\n");
    }

    public bool CheckIfContinue()
    {
      Console.Write("Would you like anything else? Y/N: ");
      return Console.ReadLine()?.Trim().ToUpper() == "Y";
    }

    public void PrintTotal(List<Order> orders)
    {
      Console.WriteLine($"Your Order:");
      foreach (var order in orders)
      {
        Console.WriteLine($"{order.Item.Product, -10} x{order.Quantity, -4}: ${order.Item.Price * order.Quantity}");
      }
      
      Console.WriteLine("------------------------");
      Console.WriteLine($"Grand Total: ${orders.Sum(o => o.Item.Price * o.Quantity)}\n");
    }

    public void GoodBye()
    {
      Console.WriteLine("Enjoy your meal!");
    }
  }
}