using NatMobile.Views;

namespace NatMobile.Views;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        // Set the background image for the page
        BackgroundImageSource = "background_image.png";

        // Create the main grid layout
        var grid = new Grid();

        // Add a background overlay for visual effect
        var overlay = new BoxView
        {
            Color = Color.FromArgb("#BF9B00"), // Semi-transparent mustard yellow
            Opacity = 0.7
        };
        grid.Children.Add(overlay);

        // Create the content layout for the page
        var contentLayout = new VerticalStackLayout
        {
            Padding = new Thickness(20),
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Children =
            {
                // App logo
                new Image
                {
                    Source = "logo.png",
                    HeightRequest = 100,
                    HorizontalOptions = LayoutOptions.Center
                },

                // Welcome message
                new Label
                {
                    Text = "Welcome",
                    FontSize = 36,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Colors.White,
                    HorizontalOptions = LayoutOptions.Center
                },

                // Description or subtitle
                new Label
                {
                    Text = "Your gateway to seamless banking.",
                    FontSize = 18,
                    FontAttributes = FontAttributes.Italic,
                    TextColor = Colors.White,
                    HorizontalOptions = LayoutOptions.Center,
                    Margin = new Thickness(0, 10, 0, 20)
                },

                // Get Started button
                new Button
                {
                    Text = "Get Started",
                    BackgroundColor = Colors.White,
                    TextColor = Color.FromArgb("#BF9B00"),
                    FontAttributes = FontAttributes.Bold,
                    HeightRequest = 50,
                    CornerRadius = 25,
                    Margin = new Thickness(0, 20, 0, 0),
                    Command = new Command(OnGetStartedClicked) // Attach navigation logic
                }
            }
        };

        // Add the content layout to the grid
        grid.Children.Add(contentLayout);

        // Set the grid as the content of the page
        Content = grid;
    }

    // Navigation logic for "Get Started" button
    private async void OnGetStartedClicked()
    {
        // Navigate to LoginPage
        await Navigation.PushAsync(new DashboardPage ());
    }
}
