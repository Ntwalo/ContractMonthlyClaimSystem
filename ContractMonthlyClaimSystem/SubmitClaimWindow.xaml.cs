using Microsoft.Win32;
using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class SubmitClaimWindow : Window
    {
        private string selectedFilePath;

        public SubmitClaimWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle claim submission logic
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please upload a supporting document before submitting.");
                return;
            }

            // Logic to handle claim submission with the selected file
            MessageBox.Show("Claim submitted successfully!");
            this.Close();
        }

        private void UploadDocumentsButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                selectedFilePath = openFileDialog.FileName;
                SelectedFileTextBlock.Text = $"Selected File: {selectedFilePath}";
            }
        }
    }
}
