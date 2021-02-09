using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPFTests.Tests
{
    public partial class _ItemsControl : Window
    {
        public _ItemsControl()
        {
            InitializeComponent();

            var qwe = new[] {1, 2};
        }
        
        public class TodoItem
        {
            public string Title { get; set; }
            public int Completion { get; set; }
        }
    }
}