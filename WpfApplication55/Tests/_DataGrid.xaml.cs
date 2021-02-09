using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace WPFTests.Tests
{
    public partial class _DataGrid : UserControl
    {
        public _DataGrid()
        {
            InitializeComponent();

            var users = new List<User1>();
            users.Add(new User1() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23) });
            users.Add(new User1() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            users.Add(new User1() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            dgUsers.ItemsSource = users;
        }
    }

    public class User1
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}