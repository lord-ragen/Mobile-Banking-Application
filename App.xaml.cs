using NatMobile.Views;

namespace NatMobile
{
    public partial class App : Application
    {
       

        private const int SessionTimeoutMinutes = 5;
    private CancellationTokenSource _logoutCancellationTokenSource;

    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new LoginPage());
    }

    protected override void OnStart()
    {
        StartSessionTimer();
    }

    protected override void OnSleep()
    {
        _logoutCancellationTokenSource?.Cancel();
    }

    protected override void OnResume()
    {
        StartSessionTimer();
    }

    private void StartSessionTimer()
    {
        _logoutCancellationTokenSource?.Cancel();
        _logoutCancellationTokenSource = new CancellationTokenSource();

        Device.StartTimer(TimeSpan.FromMinutes(SessionTimeoutMinutes), () =>
        {
            if (_logoutCancellationTokenSource.IsCancellationRequested)
                return false;

            LogoutUser();
            return false; // Stops the timer
        });
    }

    private void LogoutUser()
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            MainPage = new NavigationPage(new LoginPage());
            Application.Current.MainPage.DisplayAlert("Session Timeout", "You have been logged out due to inactivity.", "OK");
        });
    }
    }
}
