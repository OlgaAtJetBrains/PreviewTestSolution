using System.Windows;
using System.Windows.Controls;

namespace WPFTests.Tests
{
    public partial class _FlowDocumentPageViewer : UserControl
    {
        public _FlowDocumentPageViewer()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
        	fdViewer.Find();
        }
    }
}