using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFTests.tests
{
    public partial class _TextBox : UserControl
    {
        public _TextBox()
        {
            InitializeComponent();
        }
        
        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
            txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }
    }
}