using System.Data;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Kasir
{
    public class UserService
    {
        private readonly UserDAO _userDao = new UserDAO();

        // OOP pillars: Abstraction, Encapsulation
        // Simple wrapper untuk user DAO
        public DataTable GetAllUsers() => _userDao.GettAll();
    }
}
