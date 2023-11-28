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
    /// Interaction logic for CefSharpSolution.xaml
    /// </summary>
    public partial class CefSharpSolution : UserControl
    {
        private const string _orig_szakdolgozat = @"file:///C:/Development/DotNet/PDFViewer/PDFViewer/PDFs/Szakdolgozat.pdf";
        private const string _orig_lagrange = @"file:///C:/Development/DotNet/PDFViewer/PDFViewer/PDFs/Lagrange.pdf";

        private const string _html = "C:/Development/DotNet/PDFViewer/PDFViewer/bin/Debug/net5.0-windows/Assets/web/viewer.html";

        public CefSharpSolution()
        {
            InitializeComponent();
            webBrowser.Address = _html;
        }

        private void Lagrange_click(object sender, RoutedEventArgs e)
        {
        }

        private void Szakdolgozat_click(object sender, RoutedEventArgs e)
        {
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Refresh_click(object sender, RoutedEventArgs e)
        {
        }
    }
}