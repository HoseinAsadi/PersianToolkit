using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PersianToolkit
{
    public class ColorStyle
    {
      
        public static readonly DependencyProperty HolidayContentStyleProperty = DependencyProperty.RegisterAttached(
            "HolidayContentStyle", typeof(Style), typeof(ColorStyle), new FrameworkPropertyMetadata(ResourceHelper.GetResource<Style>(ResourceHolidayContentStyleToken.LabelDefault), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetHolidayContentStyle(DependencyObject element, Style value)
        {
            element.SetValue(HolidayContentStyleProperty, value);
        }

        public static Style GetHolidayContentStyle(DependencyObject element)
        {
            return (Style)element.GetValue(HolidayContentStyleProperty);
        }

        public static readonly DependencyProperty SelectedDateStyleProperty = DependencyProperty.RegisterAttached(
            "SelectedDateStyle", typeof(Brush), typeof(ColorStyle), new FrameworkPropertyMetadata(default(Brushes), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetSelectedDateStyle(DependencyObject element, Brush value)
        {
            element.SetValue(SelectedDateStyleProperty, value);
        }

        public static Brush GetSelectedDateStyle(DependencyObject element)
        {
            return (Brush)element.GetValue(SelectedDateStyleProperty);
        }

        public static readonly DependencyProperty TodayDateStyleProperty = DependencyProperty.RegisterAttached(
            "TodayDateStyle", typeof(Brush), typeof(ColorStyle), new FrameworkPropertyMetadata(default(Brushes), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetTodayDateStyle(DependencyObject element, Brush value)
        {
            element.SetValue(TodayDateStyleProperty, value);
        }

        public static Brush GetTodayDateStyle(DependencyObject element)
        {
            return (Brush)element.GetValue(TodayDateStyleProperty);
        }

        public static readonly DependencyProperty HolidayDayStyleProperty = DependencyProperty.RegisterAttached(
            "HolidayDayStyle", typeof(Brush), typeof(ColorStyle), new FrameworkPropertyMetadata(default(Brushes), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetHolidayDayStyle(DependencyObject element, Brush value)
        {
            element.SetValue(HolidayDayStyleProperty, value);
        }

        public static Brush GetHolidayDayStyle(DependencyObject element)
        {
            return (Brush)element.GetValue(HolidayDayStyleProperty);
        }
    }
}
