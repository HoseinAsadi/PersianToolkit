using System;
using System.Windows;

namespace PersianToolkit
{
    public class ResourceHelper
    {

        /// <summary>
        ///    
        /// </summary>
        /// <param name="skin"></param>
        /// <returns></returns>
        public static ResourceDictionary GetSkin(SkinType skin)
        {
            return new ResourceDictionary
            {
                Source = new Uri($"pack://application:,,,/PersianToolkit;component/Themes/Skin{skin.ToString()}.xaml")
            };
        }
    }
}