using System.Windows;
using System.Collections.ObjectModel;

namespace CMCS
{
    public partial class ClaimHistoryWindow : Window
    {
        public ClaimHistoryWindow()
        {
            InitializeComponent();
            LoadClaimHistory();
        }

        private void LoadClaimHistory()
        {
            ObservableCollection<ClaimHistory> claims = new ObservableCollection<ClaimHistory>
            {
                new ClaimHistory { ClaimId = "CLM-1001", Month = "January 2024", Hours = "40", Amount = "R 12,800.00",
                                  SubmittedDate = "2024-01-05", Status = "Approved" },
                new ClaimHistory { ClaimId = "CLM-1002", Month = "February 2024", Hours = "35", Amount = "R 11,200.00",
                                  SubmittedDate = "2024-02-03", Status = "Approved" },
                new ClaimHistory { ClaimId = "CLM-1003", Month = "March 2024", Hours = "42", Amount = "R 13,440.00",
                                  SubmittedDate = "2024-03-07", Status = "Processing" },
                new ClaimHistory { ClaimId = "CLM-1004", Month = "April 2024", Hours = "38", Amount = "R 12,160.00",
                                  SubmittedDate = "2024-04-02", Status = "Submitted" },
                new ClaimHistory { ClaimId = "CLM-1009", Month = "December 2023", Hours = "45", Amount = "R 14,400.00",
                                  SubmittedDate = "2023-12-08", Status = "Rejected" }
            };

            dgClaimHistory.ItemsSource = claims;
        }

        private void btnViewDetails_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This would show complete claim details including all line items and documents.",
                           "Claim Details", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            LecturerDashboard dashboard = new LecturerDashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnNewClaim_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaimWindow claimWindow = new SubmitClaimWindow();
            claimWindow.Show();
            this.Close();
        }

        private void btnDocuments_Click(object sender, RoutedEventArgs e)
        {
            DocumentsWindow documentsWindow = new DocumentsWindow();
            documentsWindow.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }

    public partial class ProfileWindow : Window
    {
        public new void Show()
        {
            throw new NotImplementedException();
        }
    }

    public partial class DocumentsWindow : Window
    {
        public new void Show()
        {
            throw new NotImplementedException();
        }
    }

    public class ClaimHistory
    {
        public required string ClaimId { get; set; }
        public required string Month { get; set; }
        public required string Hours { get; set; }
        public required string Amount { get; set; }
        public required string SubmittedDate { get; set; }
        public required string Status { get; set; }
    }
}