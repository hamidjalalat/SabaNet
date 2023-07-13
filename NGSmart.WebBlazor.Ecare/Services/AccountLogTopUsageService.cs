using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services
{
	public class AccountLogTopUsageService:BaseService
	{
		public AccountLogTopUsageService(HttpClient client) : base(client)
		{

		}
		protected override string GetApiUrl()
		{
			return "aaa/GetLogByAccountId";
		}

		public async Task<IList<GetLogByAccountIdResponse>> GetAsync()
		{
			var result =await GetAsync<IList<GetLogByAccountIdResponse>>();

			return result;
		}

		public async Task<GetLogByAccountIdResponse> GetAsyncAccountLogTopUsageId(
			string AccountId,
			string StartDate,
			string EndDate, 
			string ISGS_AAAServiceId,
			string ServiceType)
		{
			HttpResponseMessage response = null;

			try
			{
				response =await Http.GetAsync(requestUri: RequestUri
					+ $"?AccountId={AccountId}&&StartDate={StartDate}&&EndDate={EndDate}&&ISGS_AAAServiceId={ISGS_AAAServiceId}&&ServiceType={ServiceType} ");

				response.EnsureSuccessStatusCode();

				if (response.IsSuccessStatusCode)
				{
					try
					{
						GetLogByAccountIdResponse result =
							await response.Content.ReadFromJsonAsync<GetLogByAccountIdResponse>();

						return result;
					}
					catch (NotSupportedException)
					{
						Console.WriteLine("The content type is not supported.");
					}
					catch (JsonException)
					{
						Console.WriteLine("Invalid JSON.");
					}
				}
			}
			catch (HttpRequestException ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				response.Dispose();
			}

			return new GetLogByAccountIdResponse();
		}
	}
}
