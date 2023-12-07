using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class DialogBase : Window
    {
        public DialogBase()
        {
            if (Application.Current == null)
            {
                // Если приложение не было запущено, создаем временное Application
                new Application();
            }

            InitializeComponent();
        }

        public void InitializeComponent()
        {
            Uri uri = new Uri("/WpfApp1;component/Themes/Generic.xaml", UriKind.Relative);
            ResourceDictionary resourceDictionary = (ResourceDictionary)Application.LoadComponent(uri);
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);

            // Добавьте другие инициализации XAML, если необходимо
            ApplyTemplate();
            OnInitialized(EventArgs.Empty);
        }
    }
}