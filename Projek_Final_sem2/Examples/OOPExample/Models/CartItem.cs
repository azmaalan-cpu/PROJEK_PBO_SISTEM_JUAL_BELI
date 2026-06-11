using System;

namespace Projek_Final_sem2.Examples.OOPExample.Models
{
    public class CartItem
    {
        public int IdAlat { get; }
        public int Quantity { get; private set; }
        public decimal Price { get; }

        public CartItem(int idAlat, int quantity, decimal price)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be > 0", nameof(quantity));
            IdAlat = idAlat;
            Quantity = quantity;
            Price = price;
        }

        public decimal Subtotal => Quantity * Price;

        public void Add(int amount)
        {
            if (amount <= 0) throw new ArgumentException("amount must be > 0", nameof(amount));
            Quantity += amount;
        }
    }
}
