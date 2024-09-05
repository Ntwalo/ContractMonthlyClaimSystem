using System.Windows;
using System.Windows.Controls;

namespace ContractMonthlyClaimSystem
{
    public partial class ApproveClaimWindow : Window
    {
        public ApproveClaimWindow()
        {
            InitializeComponent();
        }

        private void ApproveClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle claim approval logic
            string claimID = ClaimIDTextBox.Text;
            string lecturerID = LecturerIDTextBox.Text;
            string claimDetails = ClaimDetailsTextBox.Text;
            string status = (StatusComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (string.IsNullOrEmpty(claimID) || string.IsNullOrEmpty(lecturerID) || string.IsNullOrEmpty(claimDetails) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill in all fields before approving the claim.");
                return;
            }

            // Logic to handle claim approval
            MessageBox.Show($"Claim {claimID} approved successfully!");
            this.Close();
        }
    }
}
