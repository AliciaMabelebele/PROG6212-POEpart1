using System.Windows;
using System.Collections.ObjectModel;

namespace CMCS
{
    public partial class CoordinatorDashboard : Window
    {
        public CoordinatorDashboard()
        {
            InitializeComponent();
            LoadPendingClaims();
        }

        private void LoadPendingClaims()
        {
            ObservableCollection<PendingClaim> claims = new ObservableCollection<PendingClaim>
            {
                new PendingClaim { ClaimId = "CLM-1005", Lecturer = "Dr. Sarah Smith", Month = "May 2024", Amount = "R 14,200.00" },
                new PendingClaim { ClaimId = "CLM-1006", Lecturer = "Dr. Michael Chen", Month = "May 2024", Amount = "R 11,500.00" },
                new PendingClaim { ClaimId = "CLM-1007", Lecturer = "Prof. Emily Davis", Month = "April 2024", Amount = "R 13,800.00" }
            };

            dgPendingClaims.ItemsSource = claims;
        }
        private void btnSwitchRole_Click(object sender, RoutedEventArgs e)
        {
            // Determine current role and switch to the other one  
            if (this.GetType() == typeof(LecturerDashboard))
            {
                CoordinatorDashboard coordinatorDash = new CoordinatorDashboard();
                coordinatorDash.Show();
            }
            else if (this.GetType() == typeof(CoordinatorDashboard))
            {
                LecturerDashboard lecturerDash = new LecturerDashboard();
                lecturerDash.Show();
            }
            this.Close();
        }
    }

    public class PendingClaim
    {
        public required string ClaimId { get; set; }
        public required string Lecturer { get; set; }
        public required string Month { get; set; }
        public required string Amount { get; set; }
    }
}