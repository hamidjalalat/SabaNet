namespace NGSmart.WebBlazor.Ecare.Models;

public class ReservedCreditChargeResponse
{
    public string Title { get; set; }
    public DateTime? StartDateTime { get; set; }
    public DateTime? EndDateTime { get; set; }
    public string ShamsiStartTime { get; set; }
    public string ShamsiEndTime { get; set; }
    public long? Charge { get; set; }
    public long? RemainCharge { get; set; }
}
