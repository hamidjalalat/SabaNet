using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services
{
    public class RemainFlatChargeService : BaseService
    {
        public RemainFlatChargeService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "aaa/GetRemainFlatCharge";
        }
        public async Task<RemainFlatChargeResponse> GetAsyncByAccountId(string accountId)
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
                        RemainFlatChargeResponse result =
                             await response.Content.ReadFromJsonAsync<RemainFlatChargeResponse>();

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

            return new RemainFlatChargeResponse();
        }
    }
}
