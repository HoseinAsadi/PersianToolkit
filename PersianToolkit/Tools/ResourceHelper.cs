using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace PersianToolkit
{
    /// <summary>
    ///     资源帮助类
    /// </summary>
    public class ResourceHelper
    {
        /// <summary>
        ///     获取HandyControl皮肤
        /// </summary>
        /// <param name="skin"></param>
        /// <returns></returns>
        public static ResourceDictionary GetSkin(SkinType skin) => new ResourceDictionary
        {
            Source = new Uri($"pack://application:,,,/PersianToolkit;component/Themes/Skin{skin.ToString()}.xaml")
        };
    }
}