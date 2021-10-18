using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BungieBounty
{
    public class GuardianSearch
    {
        public static async Task<AccountModel> SearchGuardian(string BungieName, string BungieNameCode)
        {
            string url = $"Destiny2/SearchDestinyPlayer/-1/{ BungieName }%23{ BungieNameCode }";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {

                AccountModel Guardian = new AccountModel();

                try
                {
                    string item = await response.Content.ReadAsStringAsync();

                    Guardian = JsonConvert.DeserializeObject<AccountModel>(item);

                    return Guardian;
                }
                catch (Exception)
                {
                    return Guardian;
                }
            }
        }
    }
}
