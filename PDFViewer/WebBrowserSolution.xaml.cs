using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PDFViewer
{
    /// <summary>
    /// Interaction logic for WebBrowserSolution.xaml
    /// </summary>
    public partial class WebBrowserSolution : UserControl
    {
        private const string _orig_szakdolgozat = @"file:///C:/Development/DotNet/PDFViewer/PDFViewer/PDFs/Szakdolgozat.pdf#toolbar=0&navpanes=0";
        private const string _orig_lagrange = @"file:///C:/Development/DotNet/PDFViewer/PDFViewer/PDFs/Lagrange.pdf#toolbar=0";

        public WebBrowserSolution()
        {
            InitializeComponent();

            sourceTextBox.Text = "file:///PDFs/Szakdolgozat.pdf";
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            LoadPdf(sourceTextBox.Text);
        }

        private void LoadPdf(string value)
        {
            try
            {
                webBrowser.Source = new Uri(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Szakdolgozat_click(object sender, RoutedEventArgs e)
        {
            LoadPdf(_orig_szakdolgozat);
        }

        private void Lagrange_click(object sender, RoutedEventArgs e)
        {
            LoadPdf(_orig_lagrange);
        }
    }
}