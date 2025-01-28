using System.Windows;
using ArithmeticOperations.ViewModel;

namespace ArithmeticOperations
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
