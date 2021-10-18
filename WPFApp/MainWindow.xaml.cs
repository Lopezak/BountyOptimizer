using BungieBounty;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private void ProfileSearch_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new ProfileSearchPage();
        }

        private void CharacterSearch_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new CharacterPage();
        }
    }
}
