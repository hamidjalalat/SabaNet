using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;

namespace Services
{
    public class shargePackageService : BaseService
    {
        public shargePackageService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "shargePackage";
        }

     

        public async Task<IList<PackageCard>> GetAsyncByAccountId(string AccountId)
        {
            List<PackageCard> listPackageCard = new List<PackageCard>();
            for (int i = 1; i < 20; i++)
            {
                PackageCard packageCard = new PackageCard();
                packageCard.PackageId = 125+i;
                packageCard.PackageDisplayItem1 = $"ترافیک اضافه {i} گیگابایت داخلی معادل 30 گیگابایت بین الملل" ;
                packageCard.PackageDisplayItem3 = $"ترافیک اضافه {i} گیگابایت داخلی معادل 30 گیگابایت بین الملل";
                packageCard.PackageDisplayItem2 = $"ترافیک اضافه {i} گیگابایت داخلی معادل 30 گیگابایت بین الملل";
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
