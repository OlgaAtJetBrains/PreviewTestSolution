using System.Windows.Controls;

namespace WPFTests.Tests.Bindings
{
    public partial class _Binding : UserControl
    {
        public _Binding()
        {
            InitializeComponent();
            
            this.DataContext = this;
        }
    }
}