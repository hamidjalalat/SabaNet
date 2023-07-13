using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;


namespace Services
{
    public class PackageInfoByIdService : BaseService
    {
        public PackageInfoByIdService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "PackageInfoById";
        }

        public async Task<PackageCard> GetAsyncById(string id)
        {
            PackageCard packageCard = new PackageCard();
      
                packageCard.PackageId =Convert.ToInt64(id);
                packageCard.PackageDisplayItem1 = $"سرویس 8 مگ  ماهه 5000 گیگ داخلی 2500 گیگ خارجی" ;
                packageCard.PackageDisplayItem3 = $"سرویس 8 مگ  ماهه 5000 گیگ داخلی 2500 گیگ خارجی";
                packageCard.PackageDisplayItem2 = $"سرویس 8 م  ماهه 5000 گیگ داخلی 2500 گیگ خارجی";
                packageCard.OfferingId = 125544;
                packageCard.Price = 1000;
                packageCard.Speed = 12;
                packageCard.Duration = 30;
                packageCard.Label =  30;

            var result = packageCard;

            return result;
        }
    }
}
