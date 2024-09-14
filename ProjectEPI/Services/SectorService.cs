using ProjectEPI.Data;

namespace ProjectEPI.Services
{
    public class SectorService
    {
        private readonly DatabaseManager _databaseManager;

        public SectorService(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public List<SectorData> GetSectors()
        {
            string query = "SELECT * FROM sectors ORDER BY id ASC";
           
            return _databaseManager.ExecuteScalar(query, cmd =>
            {
                var sectors = new List<SectorData>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sector = new SectorData
                        {
                            Id = (long)reader["id"],
                            Name = reader["name"].ToString()
                        };
                        sectors.Add(sector);
                    }
                }

                return sectors;
            });
        }
    }
}
