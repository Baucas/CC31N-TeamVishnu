using Engine.View_Models;
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

namespace CC31N_TeamVishnu;

public partial class MainWindow : Window
{
    private GameSession _gameSession;
    public MainWindow()
    {
        InitializeComponent();
        _gameSession = new GameSession();
        DataContext = _gameSession;
    }
}