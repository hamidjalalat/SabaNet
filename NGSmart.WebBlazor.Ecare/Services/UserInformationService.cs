using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services
{
    public class UserInformationService: BaseService
    {
        public UserInformationService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "UserInformations";
        }
        public async Task<UserInformationByPartyRoleIdResponse> GetAsyncByPartyRoleId(string partyRoleId)
        {
            var result = await base.GetAsyncByPartyRoleId<UserInformationByPartyRoleIdResponse>(partyRoleId);

            return result;
        }
    }
}
