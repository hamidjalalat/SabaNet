namespace NGSmart.WebBlazor.Ecare.Models
{
    public record PreFactorInfoByIdResponse(
         long Id,
         string PackageName,
         string StartDate,
         string EndDate,
         string ShamsiEndDate,
         string ShamsiStartDate,
         DateTime? UsedDate
        );
}
