using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace Tim.UI.Phone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }
        
        //The foreground color of the text in WatermarkTB is set to Magenta when WatermarkTB
        //gets focus.
        private void WatermarkTB_GotFocus(object sender, RoutedEventArgs e)
        {
            var tbFocused = (TextBox)sender;
            if (tbFocused.Text == String.Empty)
            {
                tbFocused.Text = "";
                var brush = new SolidColorBrush();
                brush.Color = Colors.Black;
                tbFocused.Foreground = brush;
            }
        }
        
        //The foreground color of the text in WatermarkTB is set to Blue when WatermarkTB
        //loses focus. Also, if SearchTB loses focus and no text is entered, the
        //text "Search" is displayed.
        private void WatermarkTB_LostFocus(object sender, RoutedEventArgs e)
        {
            var tbLostFocus = (TextBox)sender;

            if (tbLostFocus.Text == String.Empty)
            {
                var brush = new SolidColorBrush();
                brush.Color = Colors.Gray;
                tbLostFocus.Foreground = brush;

                switch (tbLostFocus.Name)
                {
                    case "tbAmount":
                        tbLostFocus.Text = "Amount";
                        break;
                    case "tbTitle":
                        tbLostFocus.Text = "Title";
                        break;
                }
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}