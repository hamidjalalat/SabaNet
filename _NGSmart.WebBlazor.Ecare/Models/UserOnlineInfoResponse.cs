namespace NGSmart.WebBlazor.Ecare.Models
{
    public class UserOnlineInfoResponse
    {
        public int downoad { get; set; }
        public bool downoadSpecified { get; set; }
        public int id { get; set; }
        public bool idSpecified { get; set; }
        public string ipaddress { get; set; }
        public DateTime? lastUpdate { get; set; }
        public bool lastUpdateSpecified { get; set; }
        public string lastUptime { get; set; }
        public string macaddress { get; set; }
        public string nasipaddress { get; set; }
        public string parentID { get; set; }
        public string portId { get; set; }
        public string serviceName { get; set; }
        public int sessionTime { get; set; }
        public bool sessionTimeSpecified { get; set; }
        public string sessionid { get; set; }
        public string startTime { get; set; }
        public int upload { get; set; }
        public bool uploadSpecified { get; set; }
        public string userName { get; set; }
    }
}
