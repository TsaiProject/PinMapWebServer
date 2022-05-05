using Google.Apis.Auth.OAuth2;

namespace PinMapWebServer.Services
{
    public interface IGoogleOAuthService
    {
        void UserLogin();
    }

    public class GoogleOAuthService : IGoogleOAuthService
    {
        private readonly ClientSecrets _clientSecrets;

        public GoogleOAuthService(IConfiguration config)
        {
            _clientSecrets = new ClientSecrets()
            {
                ClientId = config.GetValue<string>("Google.client_id"),
                ClientSecret = config.GetValue<string>("Google.client_secret")
            };
        }

        public void UserLogin()
        {
            var user = GoogleWebAuthorizationBroker.AuthorizeAsync(
                _clientSecrets,
                new List<string>(),
                "",
                CancellationToken.None
                ).Result;

        }
    }
}
