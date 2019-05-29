using System;
using System.Windows;
using System.Windows.Media;

namespace PersianToolkit.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ColorStyle.SetHolidayDayBrush(pc, ResourceHelper.GetResource<Brush>(ResourceBrushToken.SuccessBrush));

        }

        private void BtnDef_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).UpdateSkin(SkinType.Default);
            ColorStyle.SetHolidayContentStyle(pc, ResourceHelper.GetResource<Style>(ResourceHolidayContentStyleToken.LabelPrimary));
        }

        private void BtnDark_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).UpdateSkin(SkinType.Dark);

        }

        private void BtnVio_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).UpdateSkin(SkinType.Violet);

        }
    }
}
