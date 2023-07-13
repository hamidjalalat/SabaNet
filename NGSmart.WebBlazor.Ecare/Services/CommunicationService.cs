using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;

namespace Services
{
    public class CommunicationService : BaseService
    {
        public CommunicationService(HttpClient client) : base(client)
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
