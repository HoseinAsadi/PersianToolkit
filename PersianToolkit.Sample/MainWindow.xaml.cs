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

        private void CalendarWithClock_Confirmed()
        {
            MessageBox.Show(ct.SelectedDateTime.ToString());
        }

        private void BtnGetHijri_Click(object sender, RoutedEventArgs e)
        {
            //اگر تاریخ قمری نیاز به جلو یا عقب رفتن دارد میتوانید اختلاف موردنظر را تنظیم کنید
            //pc.GetSelectedDateToHijriDate(-1);
            MessageBox.Show(pc.GetSelectedDateToHijriDate().ToString());
        }

        private void BtnGetShamsi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pc.GetSelectedDateToPersianDate());
        }

        private void BtnGetGregorian_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pc.GetSelectedDateToGregorianDate());

        }

        private void BtnHolidayContent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pc.GetSelectedDateHolidayContent());
        }

        private void BtnTitleColor_Click(object sender, RoutedEventArgs e)
        {
            TitleElement.SetBackground(pc, Brushes.Red);
            
        }
    }
}
