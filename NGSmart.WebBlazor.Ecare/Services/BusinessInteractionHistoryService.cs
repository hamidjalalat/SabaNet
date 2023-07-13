using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;

namespace Services
{
    public class BusinessInteractionService:BaseService
	{
		public BusinessInteractionService(HttpClient client) : base(client)
		{

		}
		protected override string GetApiUrl()
		{
			return "BusinessInteraction";
		}

		public async Task<IList<BusinessInteractionHistoryByIdResponse>> GetAsync()
		{
			var result =await GetAsync<IList<BusinessInteractionHistoryByIdResponse >> ();

			return result;
		}

		public async Task<IList<BusinessInteractionHistoryByIdResponse>> GetAsyncByPartyRoleId(string partyRoleId)
		{
            var result = await base.GetAsyncByPartyRoleId<IList<BusinessInteractionHistoryByIdResponse>>(partyRoleId);

            return result;
        }
	}
}
