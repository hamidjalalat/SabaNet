using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace NGSmart.WebBlazor.Ecare.Services;

public class ReservedCreditChargeService : BaseService
{
    public ReservedCreditChargeService(HttpClient client) : base(client)
    {

    }
    protected override string GetApiUrl()
    {
        return "aaa/getReservedCreditCharge";
    }
    public async Task<List<ReservedCreditChargeResponse>> GetAsyncByAccountId(string AccountId)
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
                    List<ReservedCreditChargeResponse> result =
                         await response.Content.ReadFromJsonAsync<List<ReservedCreditChargeResponse>>();

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

        return new List<ReservedCreditChargeResponse>();
    }
}
