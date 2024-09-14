namespace ProjectEPI.Data
{
    public class EquipmentData
    {
        public long Id { get; set; }
        public string? Ca { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public string? Name { get; set; }
        public List<SectorData>? Sectors { get; set; }
        public string? Status { get; set; }
        public DateTime? MaturityDate { get; set; }
    }
}
