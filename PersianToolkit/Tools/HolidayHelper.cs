﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace PersianToolkit
{
    public class HolidayHelper
    {
        public static DateTime GetDate(DependencyObject obj)
        {
            return (DateTime)obj.GetValue(DateProperty);
        }

        public static void SetDate(DependencyObject obj, DateTime value)
        {
            obj.SetValue(DateProperty, value);
        }

        public static readonly DependencyProperty DateProperty =
        DependencyProperty.RegisterAttached("Date", typeof(DateTime), typeof(HolidayHelper), new PropertyMetadata { PropertyChangedCallback = DatePropertyChanged });

        private static void DatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var date = GetDate(d);
            SetIsHoliday(d, CheckIsHoliday(date));
        }

        private static bool CheckIsHoliday(DateTime date)
        {
            if (date.Date.ToShortDateString().Equals("16/03/1398"))
                return true;
            else
                return false;
           
        }

        private static readonly DependencyPropertyKey IsHolidayPropertyKey =
        DependencyProperty.RegisterAttachedReadOnly("IsHoliday", typeof(bool), typeof(HolidayHelper), new PropertyMetadata());

        public static readonly DependencyProperty IsHolidayProperty = IsHolidayPropertyKey.DependencyProperty;

        public static bool GetIsHoliday(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsHolidayProperty);
        }

        private static void SetIsHoliday(DependencyObject obj, bool value)
        {
            obj.SetValue(IsHolidayPropertyKey, value);
        }
    }
}
