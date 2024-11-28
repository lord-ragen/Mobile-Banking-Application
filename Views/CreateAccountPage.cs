using Microsoft.Maui.Controls;

namespace NatMobile.Views;

public partial class CreateAccountPage : ContentPage
{
    public CreateAccountPage()
    {
        // Set the background image for the page
        BackgroundImageSource = "background_image.png";

        // Create the main grid layout
        var grid = new Grid();

        // Add the background overlay
        var overlay = new BoxView
        {
            Color = Color.FromArgb("#BF9B00"), // Semi-transparent mustard yellow
            Opacity = 0.7
        };
        grid.Children.Add(overlay);

        // Create the scrollable content layout
        var scrollView = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(20),
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    // Header Label
                    new Label
                    {
                        Text = "Create New Account",
                        FontSize = 24,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Colors.White,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    // Sub-header Label
                    new Label
                    {
                        Text = "Already Registered? Log in here.",
                        FontSize = 14,
                        TextColor = Colors.White,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    // Name Entry Field
                    new Entry
                    {
                        Placeholder = "Name",
                        BackgroundColor = Colors.White,
                        TextColor = Colors.Black,
                        Margin = new Thickness(0, 10, 0, 0)
                    },
                    // Email Entry Field
                    new Entry
                    {
                        Placeholder = "Email",
                        Keyboard = Keyboard.Email,
                        BackgroundColor = Colors.White,
                        TextColor = Colors.Black,
                        Margin = new Thickness(0, 10, 0, 0)
                    },
                    // Password Entry Field
                    new Entry
                    {
                        Placeholder = "Password",
                        IsPassword = true,
                        BackgroundColor = Colors.White,
                        TextColor = Colors.Black,
                        Margin = new Thickness(0, 10, 0, 0)
                    },
                    // Sign Up Button
                    new Button
                    {
                        Text = "Sign Up",
                        BackgroundColor = Color.FromArgb("#BF9B00"),
                        TextColor = Colors.White,
                        FontAttributes = FontAttributes.Bold,
                        HeightRequest = 50,
                        CornerRadius = 25,
                        Margin = new Thickness(0, 20, 0, 0),
                        Command = new Command(OnSignUpClicked)
                    }
                }
            }
        };

        // Add scrollable content to the grid
        grid.Children.Add(scrollView);

        // Set the content of the page
        Content = grid;
    }

    private async void OnSignUpClicked()
    {
        // Perform account creation logic here (e.g., saving user data)
        await Application.Current.MainPage.DisplayAlert("Success", "Account Created Successfully!", "OK");

        // Navigate back to the Welcome Page
        await Navigation.PopToRootAsync();
    }
}
