using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace NGSmart.WebBlazor.Ecare.Services
{
    public class CreditService: BaseService
    {
        public CreditService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "Credits";
        }
        public async Task<CreditByPartyRoleIdResponse> GetAsyncByPartyRoleId(string partyRoleId)
        {
            HttpResponseMessage response = null;

            try
            {
                response = await Http.GetAsync(requestUri: RequestUri + $"?partyRoleId={partyRoleId}");

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                       CreditByPartyRoleIdResponse result =
                            await response.Content.ReadFromJsonAsync<CreditByPartyRoleIdResponse>();

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

            return new  CreditByPartyRoleIdResponse();
        }
    }
}
