﻿using livelywpf.Helpers;
using Page = System.Windows.Controls.Page;

namespace livelywpf.Views
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class AboutView : Page
    {
        public AboutView()
        {
            InitializeComponent();
            var vm = new AboutViewModel();
            this.DataContext = vm;
            this.Unloaded += vm.OnViewClosing;
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            e.Handled = true;
            LinkHandler.OpenBrowser(e.Uri);
        }
    }
}
