using System;

namespace Projek_Final_sem2.Examples.OOPExample.Models
{
    // OOP Pillars: Encapsulation
    // - Encapsulation: Exposes a controlled API for manipulating cart item quantity and computing subtotal; internal state is protected by access modifiers and validation.
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

        // OOP Pillars: Encapsulation
        // - Encapsulation: Computed property that exposes derived state without revealing internal computation details.
        public decimal Subtotal => Quantity * Price;

        // OOP Pillars: Encapsulation
        // - Encapsulation: Validation and controlled mutation of Quantity.
        public void Add(int amount)
        {
            if (amount <= 0) throw new ArgumentException("amount must be > 0", nameof(amount));
            Quantity += amount;
        }
    }
}
