using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PDFViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string _args = "chrome.exe --disable-web-security --disable-gpu --user-data-dir=%LOCALAPPDATA%\\Google\\chromeTemp";

        public App()
        {
            CefSettings settings = new CefSettings();
            //settings.CefCommandLineArgs.Add("disable-features", "BlockInsecurePrivateNetworkRequests");

            settings.CefCommandLineArgs.Add("disable-web-security", "true");
            settings.CefCommandLineArgs.Add("disable-gpu", "true");
            settings.CefCommandLineArgs.Add("user-data-dir", "%LOCALAPPDATA%\\Google\\chromeTemp");

            CefSharp.Cef.Initialize(settings);
        }
    }
}