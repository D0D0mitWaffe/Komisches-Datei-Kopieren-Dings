using System;
using System.IO;
using System.Windows.Forms;
using System.Windows;


namespace Komisches_Datei_Kopieren_Dings {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        string fromPath = @"";
        string toPath = @"";

        public MainWindow() {
            InitializeComponent();
        }

        void GetPath(int j) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if(result == System.Windows.Forms.DialogResult.OK) {
                if(j == 0) {
                    fromPath = fbd.SelectedPath;
                    FromPathBox.Text = fbd.SelectedPath;
                } else if(j == 1) {
                    toPath = fbd.SelectedPath;
                    ToPathBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void FromPathButton_Click(object sender, RoutedEventArgs e) {
            GetPath(0);
        }

        private void ToPathButton_Click(object sender, RoutedEventArgs e) {
            GetPath(1);
        }

        private void FromPathBox_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            GetPath(0);
        }

        private void ToPathBox_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            GetPath(1);
        }

    }
}
