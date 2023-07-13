namespace NGSmart.WebBlazor.Ecare.Models
{
    public class VoipUserChargeListByIdResponse
    {
        public string ID { get; set; }
        public string ChargeName { get; set; }
        public long Credit { get; set; }
        public string Serial { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StartDateStr { get; set; }
        public string EndDateStr { get; set; }
        public int? StartDateInt { get; set; }
        public int? EndDateInt { get; set; }
        public bool IsExpired { get; set; }
        public decimal RemainCharge { get; set; }

    }
}
