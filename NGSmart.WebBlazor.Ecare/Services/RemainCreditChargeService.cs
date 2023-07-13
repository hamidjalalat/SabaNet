using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services
{
    public class RemainCreditChargeService: BaseService
    {
        public RemainCreditChargeService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "aaa/GetRemainCreditCharge";
        }
        public async Task<GetRemainCreditChargeByAccountIdResponse> GetAsyncByAccountId(string AccountId)
        {
            HttpResponseMessage response = null;

            try
            {
                response = await Http.GetAsync(requestUri: RequestUri + $"?AccountId={AccountId}");

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        GetRemainCreditChargeByAccountIdResponse result =
                             await response.Content.ReadFromJsonAsync<GetRemainCreditChargeByAccountIdResponse>();

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

            return new GetRemainCreditChargeByAccountIdResponse();
        }
    }
}
