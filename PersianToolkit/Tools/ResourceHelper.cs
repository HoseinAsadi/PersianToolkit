using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public static ResourceDictionary GetSkin(SkinType skin) => new ResourceDictionary
        {
            Source = new Uri($"pack://application:,,,/PersianToolkit;component/Themes/Skin{skin.ToString()}.xaml")
        };
    }
}