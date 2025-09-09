using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media;

namespace CMCS
{
    public partial class LecturerDashboard : Window
    {
        public LecturerDashboard()
        {
            InitializeComponent();
            LoadDummyData();
            SetActiveButton(btnDashboard); // Set dashboard as active on startup
        }

        private void LoadDummyData()
        {
            ObservableCollection<Claim> claims = new ObservableCollection<Claim>
            {
                new Claim { ClaimId = "CLM-1001", Month = "January 2024", Hours = "40", Amount = "R 12,800.00", Status = "Approved" },
                new Claim { ClaimId = "CLM-1002", Month = "February 2024", Hours = "35", Amount = "R 11,200.00", Status = "Approved" },
                new Claim { ClaimId = "CLM-1003", Month = "March 2024", Hours = "42", Amount = "R 13,440.00", Status = "Processing" },
                new Claim { ClaimId = "CLM-1004", Month = "April 2024", Hours = "38", Amount = "R 12,160.00", Status = "Submitted" }
            };

            dgClaims.ItemsSource = claims;
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                SetActiveButton(button);

                // Handle navigation based on which button was clicked
                switch (button.Name)
                {
                    case "btnDashboard":
                        MessageBox.Show("Navigating to Dashboard...", "Navigation", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    case "btnNewClaim":
                        MessageBox.Show("Opening New Claim form...", "Navigation", MessageBoxButton.OK, MessageBoxImage.Information);
                        SubmitClaimWindow claimWindow = new SubmitClaimWindow();
                        claimWindow.Show();
                        this.Close();
                        break;
                    case "btnHistory":
                        MessageBox.Show("Showing Claim History...", "Navigation", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    case "btnDocuments":
                        MessageBox.Show("Opening Documents manager...", "Navigation", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    case "btnProfile":
                        MessageBox.Show("Opening Profile settings...", "Navigation", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                }
            }
        }

        private void SetActiveButton(Button activeButton)
        {
            // Reset all buttons
            btnDashboard.Background = Brushes.Transparent;
            btnDashboard.Foreground = new BrushConverter().ConvertFrom("#FFADADAD") as Brush;

            btnNewClaim.Background = Brushes.Transparent;
            btnNewClaim.Foreground = new BrushConverter().ConvertFrom("#FFADADAD") as Brush;

            btnHistory.Background = Brushes.Transparent;
            btnHistory.Foreground = new BrushConverter().ConvertFrom("#FFADADAD") as Brush;

            btnDocuments.Background = Brushes.Transparent;
            btnDocuments.Foreground = new BrushConverter().ConvertFrom("#FFADADAD") as Brush;

            btnProfile.Background = Brushes.Transparent;
            btnProfile.Foreground = new BrushConverter().ConvertFrom("#FFADADAD") as Brush;

            // Set active button style
            activeButton.Background = new BrushConverter().ConvertFrom("#FF4ECDC4") as Brush;
            activeButton.Foreground = Brushes.Black;
        }

        private void btnViewClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This would show detailed view of the selected claim.", "View Claim", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logging out...", "Logout", MessageBoxButton.OK, MessageBoxImage.Information);
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void dgClaims_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void btnSwitchRole_Click(object sender, RoutedEventArgs e)
        {
            // Determine current role and switch to the other one  
            if (this is LecturerDashboard)
            {
                CoordinatorDashboard coordinatorDash = new CoordinatorDashboard();
                coordinatorDash.Show();
            }
            else
            {
                LecturerDashboard lecturerDash = new LecturerDashboard();
                lecturerDash.Show();
            }
            this.Close();
        }
    }

    public class Claim
    {
        public required string ClaimId { get; set; }
        public required string Month { get; set; }
        public required string Hours { get; set; }
        public required string Amount { get; set; }
        public required string Status { get; set; }
    }
}