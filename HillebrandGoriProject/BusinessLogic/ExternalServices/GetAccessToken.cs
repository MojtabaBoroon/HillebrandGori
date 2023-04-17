using Newtonsoft.Json;
using ShipmentApp.ExternalServices.Abstraction;

namespace ShipmentApp.ExternalServices
{
    public class GetAccessToken : IGetAccessToken
    {
        private static readonly HttpClient _client = new HttpClient();

        public async Task<string> GetAccessTokenAsync()
        {


            var content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"grant_type", AccessTokenInfo.GrantType},
                {"scope",AccessTokenInfo.Scope},
                {"username", AccessTokenInfo.Username},
                {"password", AccessTokenInfo.Password},
                {"client_id", AccessTokenInfo.ClientId},
                {"client_secret", AccessTokenInfo.ClientSecret}
            });


            var response = await _client.PostAsync(AccessTokenInfo.TokenServerUrl, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            var responseData = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseContent);

            if (response.IsSuccessStatusCode)
            {
                return responseData["access_token"];
            }
            else
            {
                throw new Exception($"Failed to get access token: {response.StatusCode} {response.ReasonPhrase}");
            }
        }
    }
}
