namespace NGSmart.WebBlazor.Ecare.Models
{
    public class TotalUsage
    {
        public string ParentID { get; set; }
        public long UsageMB { get; set; }
        public DateTime StartDateTime { get; set; }
        public string PersianStartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string PersianEndDateTime { get; set; }
    }
}
