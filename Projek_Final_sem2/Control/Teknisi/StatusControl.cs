using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Teknisi
{
    public class StatusControl
    {
        // Field encapsulation: menyimpan ServiceDAO privat
        // OOP pillars: Encapsulation (digunakan)
        private readonly ServiceDAO _serviceDao = new ServiceDAO();

        // Update status servis
        // OOP pillars: Abstraction (exposes a clear, minimal operation to change a service's status),
        //               Encapsulation (hides DAO implementation details; delegates persistence to ServiceDAO)
        public bool UpdateStatus(int idServis, string status)
        {
            return _serviceDao.UpdateStatus(idServis, status);
        }

        // Ambil servis berdasarkan id (model)
        // OOP pillars: Abstraction (provides a focused retrieval interface returning a Service model),
        //               Encapsulation (prevents callers from interacting directly with DAO internals)
        public Projek_Final_sem2.Models.Service GetServiceById(int id)
        {
            return _serviceDao.GetServiceById(id);
        }
    }
}
