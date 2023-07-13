namespace NGSmart.WebBlazor.Ecare.Models
{
    public class GetLogByAccountIdResponse {
        public List<AccountsUsageDetail> lstAccountsUsageDetai { get; set; }
        public List<TotalUsage> lstTotalUsage { get; set; }
        public List<TotalUsagePerUsageType> lstTotalUsagePerUsageType { get; set; }

         }

}
