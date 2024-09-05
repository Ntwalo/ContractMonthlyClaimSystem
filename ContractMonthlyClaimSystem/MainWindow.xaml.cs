using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaimWindow submitClaimWindow = new SubmitClaimWindow();
            submitClaimWindow.Show();
        }

        private void VerifyClaim_Click(object sender, RoutedEventArgs e)
        {
            VerifyClaimWindow verifyClaimWindow = new VerifyClaimWindow();
            verifyClaimWindow.Show();
        }


        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            ApproveClaimWindow approveClaimWindow = new ApproveClaimWindow();
            approveClaimWindow.Show();
        }


        private void UploadDocuments_Click(object sender, RoutedEventArgs e)
        {
            UploadDocumentWindow uploadDocumentWindow = new UploadDocumentWindow();
            uploadDocumentWindow.Show();
        }


        private void TrackStatus_Click(object sender, RoutedEventArgs e)
        {
            // Open Track Status Window
        }
    }
}
