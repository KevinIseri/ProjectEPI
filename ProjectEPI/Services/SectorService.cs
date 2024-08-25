using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEPI.Data;

namespace ProjectEPI.Services
{
    public class SectorService
    {
        private readonly DatabaseManager _databaseManager;

        public SectorService()
        {
            _databaseManager = new DatabaseManager();
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
                            Id = (int)reader["id"],
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
