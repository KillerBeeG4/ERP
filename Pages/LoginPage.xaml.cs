using ERP.ViewModels;
using ERP.Windows;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ERP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
            this.KeyDown += LoginPage_KeyDown;
            (DataContext as LoginViewModel).Nav = () =>
            {
                ((App.Current as App).MainWindow.Content as Frame).Navigate(typeof(MainPage));
            };
        }

        private void LoginPage_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key == VirtualKey.Enter && (DataContext as LoginViewModel).LoginCommand.CanExecute(null))
            {
                (DataContext as LoginViewModel).LoginCommand.Execute(null);
            }
        }
    }
}
