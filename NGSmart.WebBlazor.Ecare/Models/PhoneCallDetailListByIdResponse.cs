namespace NGSmart.WebBlazor.Ecare.Models
{
    public class PhoneCallDetailListByIdResponse
    {
        public long GADestinationId { get; set; }
        public long GBDestinationId { get; set; }
        public string Anumber { get; set; }
        public string Bnumber { get; set; }
        public DateTime EventBeginDate { get; set; }
        public int EventTime { get; set; }
        public decimal UnitAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Quantity { get; set; }
        public string DateShamsi { get; set; }
    }
}
