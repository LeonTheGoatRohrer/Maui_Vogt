using System;

namespace Maui_Basics.Views;

public partial class ComponentsPage : ContentPage
{
    public ComponentsPage()
    {
        InitializeComponent();
    }

    private void OnLoadGameClicked(object sender, EventArgs e)
    {
        // Ladeanimation starten
        LoadingIndicator.IsVisible = true;
        LoadingIndicator.IsRunning = true;
        LoadGameButton.IsEnabled = false;

        // CrazyGames-URL
        string gameUrl = "https://de.crazygames.com/spiele/frontwars-io";

        // WebView starten
        GameWebView.Source = gameUrl;

        // Wenn das Laden fertig ist, Animation stoppen
        GameWebView.Navigated += (s, args) =>
        {
            LoadingIndicator.IsRunning = false;
            LoadingIndicator.IsVisible = false;
            LoadGameButton.IsEnabled = true;
        };
    }
}
