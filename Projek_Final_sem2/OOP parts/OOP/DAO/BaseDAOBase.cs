namespace Projek_Final_sem2.Examples.OOPExample.DAO
{
    public abstract class BaseDAOBase
    {

        protected object ExecuteScalar(string sql, Action<Npgsql.NpgsqlCommand> paramBinder = null)
        {
            using var conn = db.GetConnection();
            conn.Open();
            using var cmd = new Npgsql.NpgsqlCommand(sql, conn);
            paramBinder?.Invoke(cmd);
            return cmd.ExecuteScalar();
        }

        //Encapsulation
        protected object ExecuteScalar(string sql, Action<Npgsql.NpgsqlCommand> paramBinder = null)
        {
            using var conn = db.GetConnection();
            conn.Open();
            using var cmd = new Npgsql.NpgsqlCommand(sql, conn);
            paramBinder?.Invoke(cmd);
            return cmd.ExecuteScalar();
        }
    }
}