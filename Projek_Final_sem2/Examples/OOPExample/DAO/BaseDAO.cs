using System;
using Npgsql;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.Examples.OOPExample.DAO
{
    public abstract class BaseDAO
    {
        protected readonly DatabaseHelper db;

        protected BaseDAO()
        {
            db = new DatabaseHelper();
        }

        protected object ExecuteScalar(string sql, Action<Npgsql.NpgsqlCommand> paramBinder = null)
        {
            using var conn = db.GetConnection();
            conn.Open();
            using var cmd = new Npgsql.NpgsqlCommand(sql, conn);
            paramBinder?.Invoke(cmd);
            return cmd.ExecuteScalar();
        }

        protected void ExecuteNonQuery(string sql, Action<Npgsql.NpgsqlCommand> paramBinder = null)
        {
            using var conn = db.GetConnection();
            conn.Open();
            using var cmd = new Npgsql.NpgsqlCommand(sql, conn);
            paramBinder?.Invoke(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
