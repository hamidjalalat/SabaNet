namespace NGSmart.WebBlazor.Ecare.Models
{
    public class ServiceExpireDateResponse
    {
        public DateTime? expireDate { get; set; }
        public TimeSpan remainTime { get; set; }
        public string shamsiStringRemainTime { get; set; }
        public string jalaliExpireDate { get; set; }
        public string shamsiStringExpireDate { get; set; }
    }
}