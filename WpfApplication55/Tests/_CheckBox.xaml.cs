using System.Windows;
using System.Windows.Controls;

namespace WPFTests.tests
{
    public partial class _CheckBox : UserControl
    {
        public _CheckBox()
        {
            InitializeComponent();
        }
        
        private void cbAllFeatures_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures.IsChecked == true);
            CbFeatureAbc.IsChecked = newVal;
            CbFeatureXyz.IsChecked = newVal;
            CbFeatureWww.IsChecked = newVal;
        }

        private void cbFeature_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures.IsChecked = null;
            if((CbFeatureAbc.IsChecked == true) && (CbFeatureXyz.IsChecked == true) && (CbFeatureWww.IsChecked == true))
                cbAllFeatures.IsChecked = true;
            if((CbFeatureAbc.IsChecked == false) && (CbFeatureXyz.IsChecked == false) && (CbFeatureWww.IsChecked == false))
                cbAllFeatures.IsChecked = false;
        }
    }
}