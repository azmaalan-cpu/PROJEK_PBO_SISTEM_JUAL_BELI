using Projek_Final_sem2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Projek_Final_sem2.Control.Teknisi
{
    public class DataServisControl
    {
        private readonly ServiceDAO _serviceDao = new ServiceDAO();

        // Returns the latest servis dataset used by dashboard/UCs.
        public DataTable GetLatestServis()
        {
            return _serviceDao.DataServisTerbaruLengkap();
        }

        // Optional: thin wrapper for the UC data source
        public DataTable GetUcDataServis()
        {
            return _serviceDao.DataUcDataServis();
        }

        // Return model list for UcDataServis which expects List<Service>
        public System.Collections.Generic.List<Projek_Final_sem2.Models.Service> GetAllServices()
        {
            return _serviceDao.GetAllServices();
        }
    }
}
