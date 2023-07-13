using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace NGSmart.WebBlazor.Ecare.Services
{
	public class BusinessDomainPropertyService:BaseService
	{
		public BusinessDomainPropertyService(HttpClient client) : base(client)
		{

		}
		protected override string GetApiUrl()
		{
			return "BusinessDomainProperty";
		}

		public async Task<IList<BusinessDomainProperty>> GetAsync()
		{
			var result =await GetAsync<IList<BusinessDomainProperty>>();

			return result;
		}

		public async Task<IList<BusinessDomainProperty>> GetAsyncByBusinessDomainID(string businessDomainID)
		{
			HttpResponseMessage response = null;

			try
			{
				response =await Http.GetAsync(requestUri: RequestUri + $"?businessDomainID={businessDomainID}");

				response.EnsureSuccessStatusCode();

				if (response.IsSuccessStatusCode)
				{
					try
					{
						IList<BusinessDomainProperty> result =
							await response.Content.ReadFromJsonAsync<IList<BusinessDomainProperty>>();

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

			return new List<BusinessDomainProperty>();
		}
	}
}
