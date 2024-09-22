namespace ProjectEPI.Constants
{
    public class EquipmentConstants
    {
        public class EquipmentStatus
        {
            public const string VALID = "Em conformidade";
            public const string EXPIRING = "A vencer";
            public const string EXPIRED = "Vencido";
        }

        public class HandlingStatus
        {
            public const string NONE = "Nenhuma";
            public const string PENDING = "Pendente";
            public const string IN_PROGRESS = "Em andamento";
            public const string FINISHED = "Finalizado";
        }
    }
}
