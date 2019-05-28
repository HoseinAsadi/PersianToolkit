using System.Windows;

namespace PersianToolkit.Sample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ConfigHelper.Instance.SetLanguage(ConfigHelper.Language.Gregorian);
            UpdateSkin(SkinType.Default);
            base.OnStartup(e);
        }

        internal void UpdateSkin(SkinType skin)
        {
            ResourceDictionary skins0 = Resources.MergedDictionaries[0];
            skins0.MergedDictionaries.Clear();
            skins0.MergedDictionaries.Add(ResourceHelper.GetSkin(skin));
            Current.MainWindow?.OnApplyTemplate();
        }
    }
}
