using MyUmsatz.Model;
using MyUmsatz.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyUmsatz
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UmsatzViewModel umsatzViewModel = new UmsatzViewModel();
            this.DataContext = umsatzViewModel;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


    }
}