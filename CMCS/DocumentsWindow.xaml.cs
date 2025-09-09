using System.Windows;
using System.Collections.ObjectModel;

namespace CMCS
{
    public partial class DocumentsWindow : Window
    {
        public DocumentsWindow()
        {
            InitializeComponent();
            LoadDocuments();
        }

        private void LoadDocuments()
        {
            ObservableCollection<Document> documents = new ObservableCollection<Document>
            {
                new Document { FileName = "Timesheet_January.pdf", ClaimId = "CLM-1001", DocumentType = "Timesheet",
                              FileSize = "2.4 MB", UploadDate = "2024-01-05" },
                new Document { FileName = "Contract_Agreement.pdf", ClaimId = "CLM-1001", DocumentType = "Contract",
                              FileSize = "1.8 MB", UploadDate = "2024-01-05" },
                new Document { FileName = "February_Timesheet.xlsx", ClaimId = "CLM-1002", DocumentType = "Timesheet",
                              FileSize = "1.2 MB", UploadDate = "2024-02-03" },
                new Document { FileName = "March_Hours.pdf", ClaimId = "CLM-1003", DocumentType = "Timesheet",
                              FileSize = "3.1 MB", UploadDate = "2024-03-07" }
            };

            dgDocuments.ItemsSource = documents;
        }

        private void btnSelectFiles_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This would open a file dialog to select documents for upload.",
                           "Select Files", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Documents would be uploaded and linked to the selected claim.",
                           "Upload Documents", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This would download the selected document.",
                           "Download", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This would delete the selected document after confirmation.",
                           "Delete Document", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Navigation methods
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

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            ClaimHistoryWindow historyWindow = new ClaimHistoryWindow();
            historyWindow.Show();
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

    public class Document
    {
        public required string FileName { get; set; }
        public required string ClaimId { get; set; }
        public required string DocumentType { get; set; }
        public required string FileSize { get; set; }
        public required string UploadDate { get; set; }
    }
}