using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DiscoverNamur.View;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DiscoverNamur
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            contentFrame.Navigate(typeof(StartView));
            Rank_Button.IsEnabled = false;
            Course_Button.IsEnabled = false;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            HamburgerMenu.IsPaneOpen = !HamburgerMenu.IsPaneOpen;
        }
        
        // Main menu

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(StartView));
        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(RegisterView));
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(LoginView));
        }

        private void Course_Button_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(/*CourseView*/StartView));
        }

        private void Rank_Button_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(/*RankView*/LoginView));
        }

        // Footer menu

        private void Sponsor_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Credentials_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Donation_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
