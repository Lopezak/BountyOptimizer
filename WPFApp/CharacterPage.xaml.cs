using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using BungieBounty;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page
    {
        public CharacterPage()
        {
            InitializeComponent();
        }

        private async Task<AccountModel> SearchGuardian(string BungieName, string BungieNameCode)
        {
            var guardian = await GuardianSearch.SearchGuardian(BungieName, BungieNameCode);

            return guardian;
        }

        private async Task<ProfileModel> GrabCharacterInfo(string membershipType, string membershipId)
        {
            return await CharacterInfoGrab.GrabCharacterInfo(membershipType, membershipId);
        }

        private async void SearchGuardianBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var guardian = await SearchGuardian("OminousWo1f", "9098");
            var character = await GrabCharacterInfo(guardian.Response[0].membershipType.ToString(), guardian.Response[0].membershipId);


            var uriSource = new Uri("https://www.bungie.net" + character.Response.characters.data.ElementAt(0).Value.emblemPath, UriKind.Absolute);
            EmblemTestImg.Source = new BitmapImage(uriSource);
        }
    }
}
