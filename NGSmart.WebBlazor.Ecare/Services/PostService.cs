using NGSmart.WebBlazor.Ecare.Models;

namespace Services
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

        public async Task<IList<Post>>
        GetAsync()
        {
            var result = await GetAsync<IList<Post>>();

            return result;
        }
    }
}
