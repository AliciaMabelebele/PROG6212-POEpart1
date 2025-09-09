using System.Windows;
using System.Collections.ObjectModel;

namespace CMCS
{
    public partial class ReportsWindow : Window
    {
        public ReportsWindow()
        {
            InitializeComponent();
            LoadReportData();
        }

        private void LoadReportData()
        {
            ObservableCollection<ReportData> reportData = new ObservableCollection<ReportData>
            {
                new ReportData { Lecturer = "Dr. Sarah Smith", ClaimCount = "5", TotalHours = "195", TotalAmount = "R 62,400.00", AvgProcessing = "2.3 days" },
                new ReportData { Lecturer = "Dr. Michael Chen", ClaimCount = "4", TotalHours = "148", TotalAmount = "R 47,360.00", AvgProcessing = "1.8 days" },
                new ReportData { Lecturer = "Prof. Emily Davis", ClaimCount = "3", TotalHours = "115", TotalAmount = "R 36,800.00", AvgProcessing = "3.1 days" },
                new ReportData { Lecturer = "Dr. Robert Johnson", ClaimCount = "2", TotalHours = "82", TotalAmount = "R 26,240.00", AvgProcessing = "2.5 days" }
            };

            dgReport.ItemsSource = reportData;
        }

        private void btnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Report would be generated based on selected criteria.",
                           "Generate Report", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnExportPDF_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Report would be exported as PDF file.",
                           "Export PDF", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Navigation methods
        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            CoordinatorDashboard dashboard = new CoordinatorDashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnPending_Click(object sender, RoutedEventArgs e)
        {
            CoordinatorDashboard dashboard = new CoordinatorDashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnApproved_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Would show approved claims page.", "Navigation", MessageBoxButton.OK, MessageBoxImage.Information);
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

    public class ReportData
    {
        public required string Lecturer { get; set; }
        public required string ClaimCount { get; set; }
        public required string TotalHours { get; set; }
        public required string TotalAmount { get; set; }
        public required string AvgProcessing { get; set; }
    }
}