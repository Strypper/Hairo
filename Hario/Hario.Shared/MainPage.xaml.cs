using Hario.Shared.Views;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hario
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavigationViewPanel_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var item = args.SelectedItem as NavigationViewItem;
            NavView_Navigate(item);
        }
        private void NavView_Navigate(NavigationViewItem item)
        {
            switch (item.Name)
            {
                case "HomeTab":
                    MainFrame.Navigate(typeof(HomePage));
                    break;
                case "HairLocation":
                    MainFrame.Navigate(typeof(HairShopLocation));
                    break;
                case "Profile":
                    //MainFrame.Navigate(typeof(TutorPage));
                    break;
            }
        }
    }
}
