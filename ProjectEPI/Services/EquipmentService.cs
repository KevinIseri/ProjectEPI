using ProjectEPI.Data;
using static ProjectEPI.Constants.EquipmentConstants;

namespace ProjectEPI.Services
{
    public class EquipmentService
    {
        private readonly DatabaseManager _databaseManager;

        public EquipmentService(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public List<EquipmentData> GetEquipments(string orderByColumn = "id", string sortType = "ASC", bool onlyActives = false)
        {
            var quetyFilterActives = onlyActives ? "WHERE isactive = true" : "";

            var query = $"SELECT * FROM equipments {quetyFilterActives} ORDER BY {orderByColumn} {sortType}";

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
                            HandlingStatus = reader["handling_status"] != DBNull.Value ? reader["handling_status"].ToString() : HandlingStatus.NONE,
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
