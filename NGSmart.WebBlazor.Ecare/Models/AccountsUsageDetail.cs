namespace NGSmart.WebBlazor.Ecare.Models
{
    public class AccountsUsageDetail
    {
        public string disconnectCause { get; set; }
        public int id { get; set; }
        public string ipAddress { get; set; }
        public string macAddress { get; set; }
        public string nassIpAddress { get; set; }
        public string parentID { get; set; }
        public string portid { get; set; }
        public decimal ratedVolumeMB { get; set; }
        public string serviceName { get; set; }
        public int sessionTime { get; set; }
        public DateTime startDate { get; set; }
        public string startTime { get; set; }
        public DateTime stopDate { get; set; }
        public string stopTime { get; set; }
        public string userName { get; set; }
        public decimal volumeRecievedMB { get; set; }
        public decimal volumeSentMB { get; set; }
        public string usageTypeName { get; set; }
        public string color { get; set; }
        public string ShamsiStartDateTime { get; set; }
        public string ShamsiEndDateTime { get; set; }
        public decimal UploadMB { get; set; }
        public decimal DownloadMB { get; set; }
        public string PersianUsageTypeName { get; set; }

        public DateTime ConvertStartTime
        {
            get
            {
                return Convert.ToDateTime(startTime);
            }
        }

        public DateTime ConvertstopTime
        {
            get
            {
                return Convert.ToDateTime(stopTime);
            }
        }

    }
}
