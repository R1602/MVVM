﻿using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AddressBook.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell : Page
    {

        public Shell()
        {
            this.InitializeComponent();
#if DEBUG
            this.SizeChanged += Shell_SizeChanged;
#endif
            SplitViewFrame.Navigate(typeof(MainPage));

        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }

#if DEBUG
        private void Shell_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            WidthIndicator.Text = "<- " + e.NewSize.Width.ToString() + " ->";
        }
#endif
    }
}
