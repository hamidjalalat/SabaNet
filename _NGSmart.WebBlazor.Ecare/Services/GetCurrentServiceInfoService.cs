using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace NGSmart.WebBlazor.Ecare.Services;

public class GetCurrentServiceInfoService : BaseService
{
    public GetCurrentServiceInfoService(HttpClient client) : base(client)
    {

    }
    protected override string GetApiUrl()
    {
        return "getCurrentServiceInfoByAccountId";
    }
    public async Task<GetCurrentServiceInfoResponse> GetAsyncByAccountId(string accountId)
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
                    GetCurrentServiceInfoResponse result =
                         await response.Content.ReadFromJsonAsync<GetCurrentServiceInfoResponse>();

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

        return new GetCurrentServiceInfoResponse();
    }
}
