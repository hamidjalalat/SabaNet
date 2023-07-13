using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;

namespace Services
{
    public class VoipUserChargeService : BaseService
    {
        public VoipUserChargeService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "VoipUserCharge";
        }

        public async Task<IList<VoipUserChargeListByIdResponse>> GetAsync()
        {
            var result = await GetAsync<IList<VoipUserChargeListByIdResponse>>();

            return result;
        }

        public async Task<IList<VoipUserChargeListByIdResponse>> GetAsyncByAccountID(string accountID)
        {
            var result = await base.GetAsyncByAccountId<IList<VoipUserChargeListByIdResponse>>(accountID);
            return result;
        }
    }
}
