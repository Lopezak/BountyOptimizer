using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace BungieBounty
{
    public class CharacterInfoGrab
    {
        public static async Task<ProfileModel> GrabCharacterInfo(string membershipType, string destinyMembershipId)
        {
            string url = $"Destiny2/{membershipType}/Profile/{destinyMembershipId}/?components=200";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                ProfileModel profileModel = new ProfileModel();

                string item = await response.Content.ReadAsStringAsync();

                profileModel = JsonConvert.DeserializeObject<ProfileModel>(item);

                return profileModel;
            }
        }
    }
}
