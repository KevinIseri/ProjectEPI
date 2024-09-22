using ProjectEPI.Constants;
using ProjectEPI.Data;

namespace ProjectEPI.Services
{
    public class SettingService
    {
        private readonly DatabaseManager _databaseManager;

        public SettingService(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public int GetMaturityIntervalDays()
        {
            var query = $"SELECT Value FROM settings WHERE Key = '{SettingConstants.Keys.MATURITY_INTERVAL_DAYS}'";
            return _databaseManager.ExecuteScalar<int>(query, cmd => { });
        }
    }
}
