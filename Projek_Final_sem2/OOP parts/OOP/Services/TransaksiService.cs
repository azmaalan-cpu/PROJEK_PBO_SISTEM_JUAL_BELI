using System;
using System.Linq;
using System.Collections.Generic;
using Projek_Final_sem2.Examples.OOPExample.Models;
using Projek_Final_sem2.Examples.OOPExample.DAO;

namespace Projek_Final_sem2.Examples.OOPExample.Services
{
    // OOP Pillars: Encapsulation, Polymorphism
    // - Encapsulation: Contains and hides the transaction processing logic behind a single method.
    // - Polymorphism: Depends on ITransaksiDAO allowing different DAO implementations (e.g., for testing).
    public class TransaksiService : ITransaksiService
    {
        private readonly ITransaksiDAO _dao;

        public TransaksiService(ITransaksiDAO dao) => _dao = dao;

        // OOP Pillars: Encapsulation
        // - Encapsulation: ProcessTransaction orchestrates verification, persistence, and stock updates without exposing details.
        public int ProcessTransaction(int userId, IEnumerable<CartItem> items)
        {
            // encapsulate transaction logic here
            foreach (var it in items)
            {
                if (_dao.CekStok(it.IdAlat) < it.Quantity)
                    throw new InvalidOperationException($"Stok tidak cukup untuk alat {it.IdAlat}");
            }

            decimal total = items.Sum(i => i.Subtotal);
            int idTransaksi = _dao.InsertTransaksi(userId, total);
            if (idTransaksi <= 0) return -1;

            foreach (var it in items)
            {
                _dao.InsertDetail(idTransaksi, it.IdAlat, it.Quantity, it.Subtotal);
                _dao.KurangiStok(it.IdAlat, it.Quantity);
            }

            return idTransaksi;
        }
    }
}
