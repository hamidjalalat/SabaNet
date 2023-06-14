namespace NGSmart.WebBlazor.Ecare.Services
{
    public class PostService : Infrastructure.BaseService
    {
        public PostService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "Posts";
        }

        public async Task<IList<Models.Post>>
        GetAsync()
        {
            var result = await GetAsync<IList<Models.Post>>();

            return result;
        }
    }
}
