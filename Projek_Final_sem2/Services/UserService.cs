using System.Data;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Services
{
    public class UserService
    {
        private readonly UserDAO _userDao = new UserDAO();

        // Add methods as needed; simple wrapper for now
        public DataTable GetAllUsers() => _userDao.GettAll();
    }
}
