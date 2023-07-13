using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services
{
    public class IpStaticService : BaseService
    {
        public IpStaticService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "aaa/GetIpStatic";
        }
        public async Task<IpByAccountIdResponse> GetAsyncByAccountId(string accountId)
        {
            HttpResponseMessage response = null;

            try
            {
                response = await Http.GetAsync(requestUri: RequestUri + $"?AccountId={accountId}");

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        IpByAccountIdResponse result =
                             await response.Content.ReadFromJsonAsync<IpByAccountIdResponse>();

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

            return new IpByAccountIdResponse();
        }
    }
}
