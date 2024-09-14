using Npgsql;
using System.Configuration;

namespace ProjectEPI.Data
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        public void ExecuteNonQuery(string query, Action<NpgsqlCommand> parameterize)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        parameterize(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error executing query.", ex);
                }
            }
        }

        public T ExecuteScalar<T>(string query, Func<NpgsqlCommand, T> execute)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        return execute(cmd);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error executing command: ", ex);
                }

            }
        }

        public T ExecuteScalar<T>(string query, Action<NpgsqlCommand> parameterize)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Aplica os parâmetros à query (passados como uma ação)
                        parameterize(cmd);

                        // Executa o comando e captura o valor retornado pela query
                        object result = cmd.ExecuteScalar();

                        // Converte o resultado para o tipo genérico T (por exemplo, long)
                        return (T)Convert.ChangeType(result, typeof(T));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error executing scalar query: ", ex);
                }
            }
        }

    }
}
