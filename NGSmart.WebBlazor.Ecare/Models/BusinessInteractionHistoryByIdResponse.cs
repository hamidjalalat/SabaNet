namespace NGSmart.WebBlazor.Ecare.Models
{
    public record BusinessInteractionHistoryByIdResponse(
     long Id,
     string Title,
     int Price,
     string DateRefund,
     string PriceRefund,
     string ReciverRefund,
     string DateRegistration);
}
