using System.Collections.Generic;
using Projek_Final_sem2.Examples.OOPExample.Models;

namespace Projek_Final_sem2.Examples.OOPExample.Services
{
    // OOP Pillars: Abstraction, Polymorphism
    // - Abstraction: Defines the service contract without implementation details.
    // - Polymorphism: Allows swapping service implementations via the interface.
    public interface ITransaksiService
    {
        int ProcessTransaction(int userId, IEnumerable<CartItem> items);
    }
}
