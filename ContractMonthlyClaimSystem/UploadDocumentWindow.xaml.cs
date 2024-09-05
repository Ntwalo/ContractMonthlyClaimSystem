using Microsoft.Win32;
using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class UploadDocumentWindow : Window
    {
        private string selectedFilePath;

        public UploadDocumentWindow()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                selectedFilePath = openFileDialog.FileName;
                SelectedFileTextBlock.Text = $"Selected File: {selectedFilePath}";
            }
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a file before uploading.");
                return;
            }

            // Logic to handle file upload
            MessageBox.Show($"File {selectedFilePath} uploaded successfully!");
            this.Close();
        }
    }
}
