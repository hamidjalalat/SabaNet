using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services
{
    public class FreeNightService : BaseService
    {
        public FreeNightService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "aaa/getAccountFreeNightInfo";
        }
        public async Task<FreeNightResponse> GetAsyncByAccountId(string accountId)
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
                        FreeNightResponse result =
                             await response.Content.ReadFromJsonAsync<FreeNightResponse>();

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

            return new FreeNightResponse();
        }
    }
}
