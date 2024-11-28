using Microsoft.Maui.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Authentication;
using System;
using NatMobile.Views;

namespace NatMobile.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        CheckBiometricAuthentication();
    }

    private async void CheckBiometricAuthentication()
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
                        Text = "Login",
                        FontSize = 28,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Colors.White,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    // Sub-header Label
                    new Label
                    {
                        Text = "Sign in to continue.",
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
        // Navigate to CreateAccountPage
        await Navigation.PushAsync(new CreateAccountPage());
    }
}

internal class BiometricAuthenticationOptions
{
    public string Reason { get; set; }
    public object AuthenticationType { get; set; }
}

internal class BiometricAuthenticator
{
    public BiometricAuthenticator()
    {
    }

    internal async Task AuthenticateAsync(BiometricAuthenticationOptions biometricAuthenticationOptions)
    {
        throw new NotImplementedException();
    }

    internal bool IsAvailable()
    {
        throw new NotImplementedException();
    }
}