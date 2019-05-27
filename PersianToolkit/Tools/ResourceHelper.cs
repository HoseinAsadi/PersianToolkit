using System;
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
        public static ResourceDictionary GetSkin(SkinType skin)
        {
            return new ResourceDictionary
            {
                Source = new Uri($"pack://application:,,,/PersianToolkit;component/Themes/Skin{skin.ToString()}.xaml")
            };
        }
    }
}