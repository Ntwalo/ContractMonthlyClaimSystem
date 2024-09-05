using System.Windows;
using System.Windows.Controls;

namespace ContractMonthlyClaimSystem
{
    public partial class VerifyClaimWindow : Window
    {
        public VerifyClaimWindow()
        {
            InitializeComponent();
        }

        private void VerifyClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle claim verification logic
            string claimID = ClaimIDTextBox.Text;
            string lecturerID = LecturerIDTextBox.Text;
            string claimDetails = ClaimDetailsTextBox.Text;
            string status = (StatusComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (string.IsNullOrEmpty(claimID) || string.IsNullOrEmpty(lecturerID) || string.IsNullOrEmpty(claimDetails) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill in all fields before verifying the claim.");
                return;
            }

            // Logic to handle claim verification
            MessageBox.Show($"Claim {claimID} verified successfully!");
            this.Close();
        }
    }
}
