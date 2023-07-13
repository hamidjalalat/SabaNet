namespace NGSmart.WebBlazor.Ecare.Models;

public class GetCurrentServiceInfoResponse
{
    public int serviceId { get; set; }
    public int? UsedTime { get; set; }
    public string shamsiStringUsedTime { get; set; }
    public string serviceName { get; set; }
    public DateTime serviceActivateDate { get; set; }
    public string serviceActivateDateShamsi { get; set; }
    public string serviceActivateDateShamsiWithTime { get; set; }
}