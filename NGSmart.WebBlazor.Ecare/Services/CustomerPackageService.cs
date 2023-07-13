using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using NGSmart.WebBlazor.Ecare.Pages;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services
{
    public class CustomerPackageService : BaseService
    {
        public CustomerPackageService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "CustomerPackage";
        }

     

        public async Task<IList<PackageCard>> GetAsyncByAccountId(string AccountId)
        {
        
            List<PackageCard> listPackageCard = new List<PackageCard>();
            for (int i = 1; i < 20; i++)
            {
                PackageCard packageCard = new PackageCard();
                packageCard.PackageId = 125 + i;
                packageCard.PackageDisplayItem1 = $"سرویس 8 مگ {i} ماهه 5000 گیگ داخلی 2500 گیگ خارجی" ;
                packageCard.PackageDisplayItem3 = $"سرویس 8 مگ {i} ماهه 5000 گیگ داخلی 2500 گیگ خارجی";
                packageCard.PackageDisplayItem2 = $"سرویس 8 مگ {i} ماهه 5000 گیگ داخلی 2500 گیگ خارجی";
                packageCard.OfferingId = 125544;
                packageCard.Price = i*1000;
                packageCard.Speed = i;
                packageCard.Duration = i;
                packageCard.Label = i + 30;
                listPackageCard.Add(packageCard);

            }
            var result = listPackageCard;
            return result;
        }
    }
}
