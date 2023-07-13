using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace NGSmart.WebBlazor.Ecare.Services
{
    public class CommunicationListService : BaseService
    {
        public CommunicationListService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "ComminucationList";
        }

        public async Task<IList<CommunicationListByIdResponse>> GetAsync()
        {
            var result = await GetAsync<IList<CommunicationListByIdResponse>>();

            return result;
        }

        public async Task<IList<CommunicationListByIdResponse>> GetAsyncByPartyRoleId(string partyRoleId)
        {
            var result = await base.GetAsyncByPartyRoleId<IList<CommunicationListByIdResponse>>(partyRoleId);
            return result;
        }
    }
}
