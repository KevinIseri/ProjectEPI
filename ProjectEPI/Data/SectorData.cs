﻿namespace ProjectEPI.Data
{
    public class SectorData
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual List<EquipmentData>? Equipments {get; set;}
    }
}
