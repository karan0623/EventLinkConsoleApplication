
using EventLink.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using EventLinkConsoleApplication.Models;
using EventLinkConsoleApp.Models;


//This is calling the Instagram API and sending the data to the database
using (HttpClient client = new HttpClient())
{
    HttpResponseMessage response = await client.GetAsync("https://api.apify.com/v2/datasets/RhnjPNj8FcOVvk7QY/items?token=apify_api_Uea6k2FqNtwergHaVTQ5YiVQm2Q4d80BNqpH");
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

//This is calling the Facebook API and sending the data to the database
using (HttpClient client = new HttpClient())
{
    HttpResponseMessage response = await client.GetAsync("https://api.apify.com/v2/datasets/HxVl6BvdV5uUkBYis/items?token=apify_api_Uea6k2FqNtwergHaVTQ5YiVQm2Q4d80BNqpH");
    if (response.IsSuccessStatusCode)
    {
        string json = await response.Content.ReadAsStringAsync();
        FacebookPosts[] data = JsonConvert.DeserializeObject<FacebookPosts[]>(json);

        var optionsBuilder = new DbContextOptionsBuilder<FacebookPostsContext>();
        optionsBuilder.UseSqlServer("Server=tcp:eventlinkdb.database.windows.net,1433;Initial Catalog=eventlinkdb;Persist Security Info=False;User ID=eventlinkadmin;Password=Pa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        using (var context = new FacebookPostsContext(optionsBuilder.Options))
        {
            context.FacebookPosts.AddRange(data);
            await context.SaveChangesAsync();
        }
    }
    else
    {
        // Handle the error response
        throw new HttpRequestException($"API request failed with status code {response.StatusCode}");
    }
}

//This is calling the Twitter API and sending the data to the database
using (HttpClient client = new HttpClient())
{
    HttpResponseMessage response = await client.GetAsync("https://api.apify.com/v2/datasets/Bexe0nmPzFKWeZZ4q/items?token=apify_api_Uea6k2FqNtwergHaVTQ5YiVQm2Q4d80BNqpH");
    if (response.IsSuccessStatusCode)
    {
        string json = await response.Content.ReadAsStringAsync();
        Instruction[] data = JsonConvert.DeserializeObject<Instruction[]>(json);

        var optionsBuilder = new DbContextOptionsBuilder<TwitterPostsContext>();
        optionsBuilder.UseSqlServer("Server=tcp:eventlinkdb.database.windows.net,1433;Initial Catalog=eventlinkdb;Persist Security Info=False;User ID=eventlinkadmin;Password=Pa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        using (var context = new TwitterPostsContext(optionsBuilder.Options))
        {
            context.TwitterPosts.AddRange(data);
            await context.SaveChangesAsync();
        }
    }
    else
    {
        // Handle the error response
        throw new HttpRequestException($"API request failed with status code {response.StatusCode}");
    }
}