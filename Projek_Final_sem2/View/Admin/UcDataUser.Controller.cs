using System.Windows.Forms;
using System.Data;
using Projek_Final_sem2.Control.Admin;

namespace Projek_Final_sem2.View.Admin
{
    public partial class UcDataUser
    {
        private readonly DataUserControl _dataUserControl = new DataUserControl();

        // Bind DataGridView dengan data user dari controller
        public void BindUsersToGrid(DataGridView grid)
        {
            if (grid == null) return;
            var dt = _dataUserControl.MuatUsers();
            grid.DataSource = dt;
        }

        // Expose controller for advanced use
        public DataUserControl GetUserController() => _dataUserControl;
    }
}
