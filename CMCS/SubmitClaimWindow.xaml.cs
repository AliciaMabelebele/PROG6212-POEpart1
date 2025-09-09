using System.Windows;

namespace CMCS
{
    public partial class SubmitClaimWindow : Window
    {
        public SubmitClaimWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            LecturerDashboard dashboard = new LecturerDashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This would open a form to add a new claim item.", "Add Item", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Calculating total amount...", "Calculate", MessageBoxButton.OK, MessageBoxImage.Information);
            lblGrandTotal.Text = "R 9,880.00";
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This would open a file dialog to upload supporting documents.", "Upload Documents", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim submitted successfully!\nIt will now be reviewed by the Programme Coordinator.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            LecturerDashboard dashboard = new LecturerDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}