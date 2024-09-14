using ProjectEPI.Data;

namespace ProjectEPI.Services
{
    public class EquipmentService
    {
        private readonly DatabaseManager _databaseManager;

        public EquipmentService(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public List<EquipmentData> GetEquipments()
        {
            var query = "SELECT * FROM equipments ORDER BY id ASC";

            return _databaseManager.ExecuteScalar(query, cmd =>
            {
                var equipments = new List<EquipmentData>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var equipment = new EquipmentData
                        {
                            Id = (long)reader["id"],
                            Ca = reader["ca"].ToString(),
                            Description = reader["description"].ToString(),
                            IsActive = (bool)reader["isactive"],
                            Name = reader["name"].ToString(),
                            MaturityDate = reader["maturity_date"] != DBNull.Value ? (DateTime?)reader["maturity_date"] : null,
                            Status = reader["status"].ToString(),
                            Sectors = new List<SectorData>()
                        };
                        equipments.Add(equipment);
                    }
                }

                foreach (var equipment in equipments)
                {
                    var querySectors = "SELECT s.id, s.name " +
                                       "FROM public.sectors s " +
                                       "INNER JOIN public.equipmentsector es ON s.id = es.SectorId " +
                                       "WHERE es.EquipmentId = @equipmentId;";

                    var sectors = _databaseManager.ExecuteScalar(querySectors, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@equipmentId", equipment.Id);
                        var sectorList = new List<SectorData>();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var sector = new SectorData
                                {
                                    Id = (long)reader["id"],
                                    Name = reader["name"].ToString()
                                };
                                sectorList.Add(sector);
                            }
                        }
                        return sectorList;
                    });

                    equipment.Sectors = sectors;
                }

                return equipments;
            });
        }
    }
}
