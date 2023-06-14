using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;

namespace NGSmart.WebBlazor.Ecare.Services
{
	public class TransactionService:BaseService
	{
		public TransactionService(HttpClient client) : base(client)
		{

		}
		protected override string GetApiUrl()
		{
			return "GetTransactionByPartyId";
		}

		public async Task<IList<TransactionByIdResponse>> GetAsync()
		{
			var result =await GetAsync<IList<TransactionByIdResponse>> ();

			return result;
		}

		public async Task<IList<TransactionByIdResponse>> GetAsyncByPartyRoleId(string partyRoleId)
		{
            var result = await base.GetAsyncByPartyRoleId<IList<TransactionByIdResponse>>(partyRoleId);

            return result;
        }
	}
}
