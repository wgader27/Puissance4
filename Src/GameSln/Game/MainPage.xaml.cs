using Game.Page;
using Microsoft.Maui.Controls;

namespace Game
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AppShell.SetNavBarIsVisible(this, false);

        }

        private void EnvoiGame(object sender, EventArgs e)
        {
            // Naviguer vers la page Jeu.xaml
            Navigation.PushAsync(new Jeu());
        }
    }
}
