using System.Windows.Controls;

namespace WPFTests.tests
{
    public partial class _Label : UserControl
    {
        public _Label()
        {
            InitializeComponent();
        }
    }
}

/*
 *   <WpfApplication55>\tests\_Border.xaml.cs:185 Ambiguous invocation:
  void InitializeComponent() (in class _Border)
  void System.Windows.Markup.IComponentConnector.InitializeComponent() (in class _Border)
match
 */