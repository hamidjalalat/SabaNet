namespace NGSmart.WebBlazor.Ecare.Models
{
    public class FreeNightResponse
    {
        public bool hasfreeNight { get; set; }
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public string fromDateShamsi { get; set; }
        public string toDateShamsi { get; set; }
        public string fromDateShamsiWithName { get; set; }
        public string toDateShamsiWithName { get; set; }
        public int? freeNightPercent { get; set; }
        public string freeNightPercentText { get; set; }
        public string freeNightPeriod { get; set; }
    }
}