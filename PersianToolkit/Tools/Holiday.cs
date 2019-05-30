using System.Windows;

namespace PersianToolkit
{
    /// <summary>
    /// کلاسی برای نمایش مناسبت ها
    /// </summary>
    public class Holiday
    {
        public static readonly DependencyProperty ShowHolidayProperty = DependencyProperty.RegisterAttached(
         "ShowHoliday", typeof(bool), typeof(Holiday), new FrameworkPropertyMetadata(ValueBoxes.FalseBox, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetShowHoliday(DependencyObject element, bool value)
        {
            element.SetValue(ShowHolidayProperty, value);
        }

        public static bool GetShowHoliday(DependencyObject element)
        {
            return (bool)element.GetValue(ShowHolidayProperty);
        }
    }
}
