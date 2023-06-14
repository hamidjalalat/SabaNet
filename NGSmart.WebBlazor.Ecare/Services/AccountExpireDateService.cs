using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace NGSmart.WebBlazor.Ecare.Services
{
    public class ServiceExpireDateService: BaseService
    {
        public ServiceExpireDateService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "aaa/getServiceExpireDateByAccountID";
        }
        public async Task<ServiceExpireDateResponse> GetAsyncByPartyRoleId(string AccountId)
        {
            HttpResponseMessage response = null;

            try
            {
                response = await Http.GetAsync(requestUri: RequestUri + $"?AccountId={ AccountId }");

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        ServiceExpireDateResponse result =
                            await response.Content.ReadFromJsonAsync<ServiceExpireDateResponse>();

                        return result;
                    }
                    catch (NotSupportedException )
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

            return new ServiceExpireDateResponse();
        }
    }
}
