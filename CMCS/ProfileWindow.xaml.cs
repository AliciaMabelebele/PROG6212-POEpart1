using System.Windows;

namespace CMCS
{
    public partial class ProfileWindow : Window
    {
        public ProfileWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Profile changes would be saved to the database.",
                           "Save Changes", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            LecturerDashboard dashboard = new LecturerDashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            LecturerDashboard dashboard = new LecturerDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}