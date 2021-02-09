using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPFTests.tests
{
    public partial class _TextBlock : UserControl
    {
        public _TextBlock()
        {
            InitializeComponent();
        }
        
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}