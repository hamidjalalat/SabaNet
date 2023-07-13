using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;


namespace Services
{
    public class IPStaticPackageService : BaseService
    {
        public IPStaticPackageService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "IPStaticPackage";
        }

     

        public async Task<IList<PackageCard>> GetAsyncByAccountId(string AccountId)
        {
            List<PackageCard> listPackageCard = new List<PackageCard>();
            for (int i = 1; i < 8; i++)
            {
                PackageCard packageCard = new PackageCard();
                packageCard.PackageId = 12+i;
                packageCard.PackageDisplayItem1 = $"{i} ماهه تک کاربره IP STATIC سرویس" ;
                packageCard.PackageDisplayItem3 = $"{i} ماهه تک کاربره IP STATIC سرویس";
                packageCard.PackageDisplayItem2 = $"{i} ماهه تک کاربره IP STATIC سرویس";
                packageCard.OfferingId = 12 + i;
                packageCard.Price = i*1000;
                packageCard.Speed = i;
                packageCard.Duration = i;
                packageCard.Label = i + 30;
                packageCard.Type = i;
                listPackageCard.Add(packageCard);

            }
            var result = listPackageCard;
            return result;
        }
    }
}
