using System.Collections.Generic;
using Projek_Final_sem2.Examples.OOPExample.Models;

namespace Projek_Final_sem2.Examples.OOPExample.Services
{
    public interface ITransaksiService
    {
        int ProcessTransaction(int userId, IEnumerable<CartItem> items);
    }
}
