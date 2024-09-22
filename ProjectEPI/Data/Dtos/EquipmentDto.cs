namespace ProjectEPI.Data.Dtos
{
    public class EquipmentDto
    {
        public long Id { get; set; }
        public string Ca { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string? HandlingStatus { get; set; }
        public DateTime? MaturityDate { get; set; }
    }
}
