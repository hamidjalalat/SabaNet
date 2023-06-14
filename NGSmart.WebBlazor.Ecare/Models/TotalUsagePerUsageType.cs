namespace NGSmart.WebBlazor.Ecare.Models
{
    public class TotalUsagePerUsageType
    {
        public string TypeName { get; set; }
        public long SumDownloadMB { get; set; }
        public long SumUploadMB { get; set; }
    }
}
