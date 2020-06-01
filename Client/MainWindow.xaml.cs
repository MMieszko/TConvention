using System.Reflection;
using System.Windows;
using TConvention.Core;
using TConvention.Core.Utils;


namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            Assembly.GetExecutingAssembly()
                .Has()
                .MethodConventions().CamelCase().AsyncSuffix()
                .AndHas();
        }

        public void chuj()
        {

        }
    }
}
