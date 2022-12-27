using System;

namespace Marigolds.Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Marigolds marigolds = new Marigolds();
            do {
                marigolds.PrintMenu(marigolds.menu);
                var item = marigolds.InputItem(marigolds.menu);
                var quantity = marigolds.InputQuantity();
                marigolds.orders.Add(new Order(item, quantity));
                marigolds.PrintSubTotal(marigolds.orders);
            } while (marigolds.CheckIfContinue());
            marigolds.PrintTotal(marigolds.orders);
            marigolds.GoodBye();
        }
    }
}