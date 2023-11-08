using EventLink.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;



using (HttpClient client = new HttpClient())
{
    HttpResponseMessage response = await client.GetAsync("https://api.apify.com/v2/actor-tasks/exclusive_commode~eventlink---instagram-post-scraper/run-sync-get-dataset-items?token=apify_api_Uea6k2FqNtwergHaVTQ5YiVQm2Q4d80BNqpH");
    if (response.IsSuccessStatusCode)
    {
        string json = await response.Content.ReadAsStringAsync();
        InstagramPosts[] data = JsonConvert.DeserializeObject<InstagramPosts[]>(json);

        var optionsBuilder = new DbContextOptionsBuilder<InstagramPostsContext>();
        optionsBuilder.UseSqlServer("Server=tcp:eventlinkdb.database.windows.net,1433;Initial Catalog=eventlinkdb;Persist Security Info=False;User ID=eventlinkadmin;Password=Pa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        using (var context = new InstagramPostsContext(optionsBuilder.Options))
        {
            context.InstagramPosts.AddRange(data);
            await context.SaveChangesAsync();
        }
    }
    else
    {
        // Handle the error response
        throw new HttpRequestException($"API request failed with status code {response.StatusCode}");
    }
}


