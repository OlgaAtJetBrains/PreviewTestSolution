using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFTests.tests
{
    public partial class _Slider : UserControl
    {
        public _Slider()
        {
            InitializeComponent();
        }
        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        	Color color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
        	this.Background = new SolidColorBrush(color);
        }
    }
}