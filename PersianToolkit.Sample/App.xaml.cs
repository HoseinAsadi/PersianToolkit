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
            base.OnStartup(e);
        }
    }
}
