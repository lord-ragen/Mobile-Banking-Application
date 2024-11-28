using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace NatMobile.ViewModels;

public class DashboardViewModel : BindableBase
{
    // Properties
    private string _title = "Home";
    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    private string _welcomeMessage = "Welcome back, Alfredo Torres";
    public string WelcomeMessage
    {
        get => _welcomeMessage;
        set => SetProperty(ref _welcomeMessage, value);
    }

    private string _balance = "$5,500.50";
    public string Balance
    {
        get => _balance;
        set => SetProperty(ref _balance, value);
    }

    private string _accountNumber = "**** 1234";
    public string AccountNumber
    {
        get => _accountNumber;
        set => SetProperty(ref _accountNumber, value);
    }

    private string _recentTransactionsTitle = "Recent Transactions";
    public string RecentTransactionsTitle
    {
        get => _recentTransactionsTitle;
        set => SetProperty(ref _recentTransactionsTitle, value);
    }

    private string _profileImage = "profile_placeholder.png"; // Replace with actual image path
    public string ProfileImage
    {
        get => _profileImage;
        set => SetProperty(ref _profileImage, value);
    }

    // Commands
    public DelegateCommand NotificationCommand { get; }
    public DelegateCommand ShowQrCommand { get; }

    // Transactions List
    public ObservableCollection<TransactionModel> RecentTransactions { get; }

    // Constructor
    public DashboardViewModel()
    {
        // Initialize commands
        NotificationCommand = new DelegateCommand(OnNotificationTapped);
        ShowQrCommand = new DelegateCommand(OnQrTapped);

        // Populate Recent Transactions
        RecentTransactions = new ObservableCollection<TransactionModel>
        {
            new TransactionModel { Title = "Fauget Cafe", Type = "Payment", Status = "Success" },
            new TransactionModel { Title = "Larana, Inc.", Type = "Payment", Status = "Success" },
            new TransactionModel { Title = "Claudia Alves", Type = "Transfer", Status = "Failed" },
            new TransactionModel { Title = "Borcelle Cafe", Type = "Payment", Status = "Success" }
        };
    }

    // Command Handlers
    private void OnNotificationTapped()
    {
        // Logic for handling notification button tap
        // Example: Navigate to notifications page or display a message
    }

    private void OnQrTapped()
    {
        // Logic for handling QR code button tap
        // Example: Show QR code in a popup or navigate to QR details page
    }
}

// Transaction Model
public class TransactionModel
{
    public string Title { get; set; }
    public string Type { get; set; }
    public string Status { get; set; }
}
