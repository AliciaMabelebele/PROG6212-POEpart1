using System.Windows;
using System.Windows.Controls;

namespace CMCS
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Ensure cmbRole.SelectedItem is not null before accessing its properties  
            if (cmbRole.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedRole = selectedItem.Content?.ToString() ?? string.Empty;

                if (selectedRole == "Lecturer")
                {
                    LecturerDashboard lecturerDash = new LecturerDashboard();
                    lecturerDash.Show();
                }
                else if (selectedRole == "Programme Coordinator" || selectedRole == "Academic Manager")
                {
                    CoordinatorDashboard coordinatorDash = new CoordinatorDashboard();
                    coordinatorDash.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a role before logging in.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}