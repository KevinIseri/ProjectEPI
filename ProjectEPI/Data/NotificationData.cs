namespace ProjectEPI.Data
{
    public class NotificationData
    {
        public long Id { get; set; }
        public virtual EquipmentData Equipment { get; set; }
    }
}
