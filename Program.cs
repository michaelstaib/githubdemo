using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;

namespace Demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient(
                "GitHubClient",
                c =>
                {
                    c.BaseAddress = new Uri("https://api.github.com/graphql");
                    c.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("EFCoreTools", "1.0")));
                    c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", "YOUR TOKEN");
                });
            serviceCollection
                .AddGitHubClient()
                .AddValueSerializer(() => new UriValueSerializer());

            var client = serviceCollection
                .BuildServiceProvider()
                .GetRequiredService<IGitHubClient>();

            var result = await client.GetPullRequestsAsync();
            result.EnsureNoErrors();

            foreach (var item in result.Data!.Repository.Label.PullRequests.Nodes)
            {
                Console.WriteLine(item.Author.Login);
            }
        }
    }
}
