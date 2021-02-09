using System.Windows.Controls;
using System.Windows.Input;

namespace WPFTests.Tests
{
    public partial class _ToolBar : UserControl
    {
        public _ToolBar()
        {
            InitializeComponent();
        }
        
        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
        	e.CanExecute = true;
        }
    }
}