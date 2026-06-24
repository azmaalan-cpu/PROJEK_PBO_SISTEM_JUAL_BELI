using System.Data;

namespace Projek_Final_sem2.Control.Teknisi
{
    public interface ITeknisiDashboardController
    {
        DataTable GetLatestServis();
        DataTable GetUcDataServis();
    }
}
