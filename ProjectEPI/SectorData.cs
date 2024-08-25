using Npgsql;
using System.Configuration;
using System.Data;

namespace ProjectEPI
{
    public class SectorData
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        NpgsqlConnection conn = new(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

        public List<SectorData> GetSectors()
        {
            List<SectorData> sectors = [];

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string querySelect = "SELECT * FROM sectors order by id asc";

                    using (NpgsqlCommand cmd = new() { Connection = conn, CommandText = querySelect })
                    {
                        NpgsqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SectorData sd = new()
                            {
                                Id = (int)reader["id"],
                                Name = reader["name"].ToString()
                            };

                            sectors.Add(sd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: ", ex);
                }
                finally
                {
                    conn.Close();
                }
            }

            return sectors;
        }

    }
}
