using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using BungieBounty;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for ProfileSearchPage.xaml
    /// </summary>
    public partial class ProfileSearchPage : Page
    {
        public ProfileSearchPage()
        {
            InitializeComponent();
        }

        private async Task SearchGuardian(string BungieName, string BungieNameCode)
        {
            var guardian = await GuardianSearch.SearchGuardian(BungieName, BungieNameCode);
            if (guardian.Response != null)
            {
                setErrorVisibility();
                BungieNameAndCodeText.Text = guardian.Response[0].bungieGlobalDisplayName + "#" + guardian.Response[0].bungieGlobalDisplayNameCode;
                BungieMembershipIDText.Text = guardian.Response[0].membershipId;
                BungieMembershipTypeText.Text = guardian.Response[0].membershipType.ToString();
                
            }
            else
            {
                setErrorVisibility("visible");
            }
        }

        private async void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (BungieNameInput.Text.Contains("#"))
            {
                string BungieName = BungieNameInput.Text.Split("#")[0];
                string BungieNameCode = BungieNameInput.Text.Split("#")[1];

                await SearchGuardian(BungieName, BungieNameCode);
            }
            else
            {
                setErrorVisibility("visible");
            }
        }

        private void setErrorVisibility(string visibility = null)
        {
            if(visibility == "visible")
            {
                ErrorDisply.Visibility = Visibility.Visible;
                BungieNameAndCodeText.Visibility = Visibility.Hidden;
                BungieMembershipTypeText.Visibility = Visibility.Hidden;
                BungieMembershipIDText.Visibility = Visibility.Hidden;
            }
            else
            {
                ErrorDisply.Visibility = Visibility.Hidden;
                BungieNameAndCodeText.Visibility = Visibility.Visible;
                BungieMembershipTypeText.Visibility = Visibility.Visible;
                BungieMembershipIDText.Visibility = Visibility.Visible;
            }
        }
    }
}
