using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFTests.Tests
{
    public partial class _Command : UserControl
    {
        public _Command()
        {
            InitializeComponent();
        }
        
        private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
        	e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
        }

        private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        	txtEditor.Cut();
        }

        private void PasteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
        	e.CanExecute = Clipboard.ContainsText();
        }

        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        	txtEditor.Paste();
        }
    }
}