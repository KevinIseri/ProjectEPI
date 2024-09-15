namespace ProjectEPI.Data
{
    public class EquipmentData
    {
        public long Id { get; set; }
        public string Ca { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public virtual List<SectorData> Sectors { get; set; }
        public string Status { get; set; }
        public string? HandlingStatus { get; set; }
        public DateTime? MaturityDate { get; set; }

        public string SectorsDisplay
        {
            get
            {
                return string.Join(", ", Sectors?.Select(s => s.Name) ?? Enumerable.Empty<string>());
            }
        }
    }
}
