using Azure.Identity;
using ITS.WWS.WebApp.Azure;
using Microsoft.Graph;

namespace ITS.WWS.WebApp.Services
{
    public class GraphService
    {
        public GraphServiceClient GraphServiceClient { get; set; } = null!;

        public GraphService(AzureAdConfiguration azureAdConfiguration)
        {
            _azureAdConfiguration = azureAdConfiguration;
            string[] scopes = new[] { "https://graph.microsoft.com/.default" };
            var credential = new ClientSecretCredential(_azureAdConfiguration.TenantId, _azureAdConfiguration.ClientId, _azureAdConfiguration.ClientSecret);
            GraphServiceClient = new(credential, scopes);
        }

        private readonly AzureAdConfiguration _azureAdConfiguration = null!;

    }
}
