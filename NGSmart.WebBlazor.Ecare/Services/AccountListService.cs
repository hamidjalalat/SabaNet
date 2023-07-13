using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services
{
    public class AccountListService : BaseService
    {
        public AccountListService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "Parties/getAccountListOfPartyByPartyRoleId";
        }

        public async Task<IList<GetAccountListOfPartyByPartyRoleIdResponse>> GetAsync()
        {
            var result = await GetAsync<IList<GetAccountListOfPartyByPartyRoleIdResponse>>();

            return result;
        }

        public async Task<GetAccountListOfPartyByPartyRoleIdResponse> GetAsyncByPartyRoleId(string partyRoleId)
        {
            var result = await base.GetAsyncByPartyRoleId<GetAccountListOfPartyByPartyRoleIdResponse>(partyRoleId);

            return result;
        }
      
    }
}
