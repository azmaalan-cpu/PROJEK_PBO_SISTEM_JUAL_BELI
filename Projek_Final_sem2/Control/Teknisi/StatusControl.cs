using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Teknisi
{
    public class StatusControl
    {
        private readonly ServiceDAO _serviceDao = new ServiceDAO();

        public bool UpdateStatus(int idServis, string status)
        {
            return _serviceDao.UpdateStatus(idServis, status);
        }

        public Projek_Final_sem2.Models.Service GetServiceById(int id)
        {
            return _serviceDao.GetServiceById(id);
        }
    }
}
