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
                            Name = reader["name"].ToString()
                        };
                        equipments.Add(equipment);
                    }
                }

                return equipments;
            });
        }
    }
}
