namespace NGSmart.WebBlazor.Ecare.Models
{
    public class PackageCard
    {
        public string PackageDisplayItem1 { get; set; }
        public string PackageDisplayItem2 { get; set; }
        public string PackageDisplayItem3 { get; set; }
        public long PackageId { get; set; }
        public long OfferingId { get; set; }
        public decimal Price { get; set; }
        public int Speed { get; set; }
        public int Duration { get; set; }
        public int Label { get; set; }
        public int Type { get; set; }
        public ServiceType ServiceType { get; set; }
    }
    public enum ServiceType
    {
        Unknown,
        ADSL,
        Fibre,
    }
}
