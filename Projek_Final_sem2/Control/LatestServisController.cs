using System.Data;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control
{
    public class LatestServisController
    {
        private readonly ServiceDAO _serviceDao = new ServiceDAO();

        public DataTable GetLatestServis()
        {
            return _serviceDao.DataServisTerbaruLengkap();
        }
    }
}
