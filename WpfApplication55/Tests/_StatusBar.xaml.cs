using System.Windows;
using System.Windows.Controls;

namespace WPFTests.Tests
{
    public partial class _StatusBar : UserControl
    {
        public _StatusBar()
        {
            InitializeComponent();
        }
        
        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = TxtEditor.GetLineIndexFromCharacterIndex(TxtEditor.CaretIndex);
            int col = TxtEditor.CaretIndex - TxtEditor.GetCharacterIndexFromLineIndex(row);
            LblCursorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
        }
    }
}