using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;

namespace Services
{
    public class PhoneCallDetailService : BaseService
    {
        public PhoneCallDetailService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "GetPhoneCallDetailByAccountId";
        }

        public async Task<IList<PhoneCallDetailListByIdResponse>> GetAsync()
        {
            var result = await GetAsync<IList<PhoneCallDetailListByIdResponse>>();

            return result;
        }

        public async Task<IList<PhoneCallDetailListByIdResponse>> GetAsyncByAccountID(string accountID)
        {
            var result = await base.GetAsyncByAccountId<IList<PhoneCallDetailListByIdResponse>>(accountID);
            return result;
        }
    }
}
