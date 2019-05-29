using System;
using System.Windows;

namespace PersianToolkit.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDef_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).UpdateSkin(SkinType.Default);

        }

        private void BtnDark_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).UpdateSkin(SkinType.Dark);

        }

        private void BtnVio_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).UpdateSkin(SkinType.Violet);

        }
    }
}
