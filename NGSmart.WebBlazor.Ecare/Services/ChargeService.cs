using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;

namespace Services
{
    public class ChargeService: BaseService
    {
        public ChargeService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "Charge";
        }
        public async Task<ChargeByIdResponses> GetChargeById(string partyRoleId)
        {
            var result =await  GetAsyncById<ChargeByIdResponses>(partyRoleId);

            return result;
        }
    }
}
