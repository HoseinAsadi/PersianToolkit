using System.Windows;

namespace PersianToolkit
{
    /// <summary>
    /// کلاسی برای پراپرتی های کاربردی
    /// </summary>
    public class CalendarAttached
    {
        public static readonly DependencyProperty ShowHolidayProperty = DependencyProperty.RegisterAttached(
         "ShowHoliday", typeof(bool), typeof(CalendarAttached), new FrameworkPropertyMetadata(ValueBoxes.FalseBox, FrameworkPropertyMetadataOptions.Inherits));

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
