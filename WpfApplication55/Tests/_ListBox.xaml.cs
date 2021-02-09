using System.Collections.Generic;
using System.Windows;

namespace WPFTests.Tests
{
    public partial class _ListBox : Window
    {
        public _ListBox()
        {
            InitializeComponent();
            var items = new List<_ItemsControl.TodoItem>
            {
                new _ItemsControl.TodoItem {Title = "Complete this WPF tutorial", Completion = 45},
                new _ItemsControl.TodoItem {Title = "Learn C#", Completion = 80},
                new _ItemsControl.TodoItem {Title = "Wash the car", Completion = 0}
            };

            lbTodoList.ItemsSource = items;
        }
        
        private void lbTodoList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(lbTodoList.SelectedItem != null)
                this.Title = (lbTodoList.SelectedItem as _ItemsControl.TodoItem)?.Title;
        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            foreach(var o in lbTodoList.SelectedItems)
                MessageBox.Show((o as _ItemsControl.TodoItem)?.Title);
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            lbTodoList.SelectedIndex = lbTodoList.Items.Count - 1;
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            var nextIndex = 0;
            if((lbTodoList.SelectedIndex >= 0) && (lbTodoList.SelectedIndex < (lbTodoList.Items.Count - 1)))
                nextIndex = lbTodoList.SelectedIndex + 1;
            lbTodoList.SelectedIndex = nextIndex;
        }

        private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach(var o in lbTodoList.Items)
            {
                if((o is _ItemsControl.TodoItem) && ((o as _ItemsControl.TodoItem).Title.Contains("C#")))
                {
                    lbTodoList.SelectedItem = o;
                    break;
                }
            }
        }
        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach(var o in lbTodoList.Items)
                lbTodoList.SelectedItems.Add(o);
        }


    }

    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }
}