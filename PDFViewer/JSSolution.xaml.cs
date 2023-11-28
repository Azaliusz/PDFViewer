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
    /// Interaction logic for JSSolution.xaml
    /// </summary>
    public partial class JSSolution : UserControl
    {
        private const string _orig_szakdolgozat = @"file:///C:/Development/DotNet/PDFViewer/PDFViewer/PDFs/Szakdolgozat.pdf";
        private const string _orig_lagrange = @"file:///C:/Development/DotNet/PDFViewer/PDFViewer/PDFs/Lagrange.pdf";

        private const string _html = "C:/Development/DotNet/PDFViewer/PDFViewer/bin/Debug/net5.0-windows/Assets/web/viewer.html";

        public JSSolution()
        {
            InitializeComponent();
            webBrowser.Navigating += WebBrowser_Navigating;

            webBrowser.Source = new(_html);
        }

        private void WebBrowser_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            // Inject JavaScript to catch errors
            dynamic document = webBrowser.Document;

            if (document != null)
            {
                dynamic script = document.parentWindow.Script;
                if (script != null)
                {
                    script.onerror = new Action<string, string, int>((message, source, line) =>
                    {
                        MessageBox.Show($"Error: {message} at line {line} in {source}");
                    });
                }
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

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = new(_html);
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

        private void Refresh_click(object sender, RoutedEventArgs e)
        {
            webBrowser.Refresh();
        }
    }
}