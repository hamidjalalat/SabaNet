using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services
{
    public class PreFactorInfoService : BaseService
    {
        public PreFactorInfoService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "PreFactorInfo";
        }

        public async Task<IList<PreFactorInfoByIdResponse>> GetAsync()
        {
            var result = await GetAsync<IList<PreFactorInfoByIdResponse>>();

            return result;
        }

        public async Task<IList<PreFactorInfoByIdResponse>> GetAsyncByPartyRoleId(string partyRoleId)
        {
            var result = await base.GetAsyncByPartyRoleId<IList<PreFactorInfoByIdResponse>>(partyRoleId);

            return result;
        }
    }
}
