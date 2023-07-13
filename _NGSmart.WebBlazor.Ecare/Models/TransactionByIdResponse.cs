namespace NGSmart.WebBlazor.Ecare.Models
{
    public record TransactionByIdResponse(
                 string NameTransaction,
                 decimal PriceTransaction,
                 string StartDate,
                 string StatusName,
                 decimal CurrentValue,
                 string CompletedDate,
                 string Description
      );
}
