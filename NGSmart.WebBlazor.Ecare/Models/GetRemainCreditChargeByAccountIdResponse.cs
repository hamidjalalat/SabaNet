namespace NGSmart.WebBlazor.Ecare.Models
{
    public class GetRemainCreditChargeByAccountIdResponse
    {
        public int RemainCreditChargeMB { get; set; }
        public string RemainCreditChargeEnGBMB { get; set; }
        public string RemainCreditChargeFaGBMB { get; set; }
        public string RemainCreditDateTime { get; set; }
        public string RemainCreditShamsiDateTime { get; set; }
        public string RemainCreditShamsiDateTimeWithName { get; set; }
        public string NextCreditDateTime { get; set; }
        public string NextCreditShamsiDateTime { get; set; }
        public string NextCreditShamsiDateTimeWithName { get; set; }
    }
}
