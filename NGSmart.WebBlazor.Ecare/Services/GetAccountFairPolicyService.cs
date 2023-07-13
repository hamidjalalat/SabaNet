using Infrastructure;
using NGSmart.WebBlazor.Ecare.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services;

public class GetAccountFairPolicyService : BaseService
{
    public GetAccountFairPolicyService(HttpClient client) : base(client)
    {

    }
    protected override string GetApiUrl()
    {
        return "aaa/getAccountFairPolicy";
    }
    public async Task<GetAccountFairPolicyResponse> GetAsyncByAccountId(string accountId)
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
                    GetAccountFairPolicyResponse result =
                         await response.Content.ReadFromJsonAsync<GetAccountFairPolicyResponse>();

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

        return new GetAccountFairPolicyResponse();
    }
}
