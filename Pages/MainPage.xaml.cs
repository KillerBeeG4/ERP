using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ERP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            FrisbeePanel.PointerPressed += FrisbeePanel_PointerPressed;
            EggPanel.PointerPressed += FrisbeePanel_PointerPressed;
            ProceduresPanel.PointerPressed += FrisbeePanel_PointerPressed;
        }

        private void FrisbeePanel_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            var name = ((StackPanel)sender).Name;
            string tableName = "";
            switch(name)
            {
                case "FrisbeePanel":
                    tableName = "frisbee";
                    break;
                case "EggPanel":
                    tableName = "egg";
                    break;
                case "ProceduresPanel":
                    tableName = "procedures";
                    break;
            }

            (Parent as Frame).Navigate(typeof(TablePage), tableName);
        }
    }
}
