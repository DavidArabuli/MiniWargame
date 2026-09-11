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

namespace MiniWargame
{
    public partial class MainWindow : Window
    {
        // Board settings
        private const int TileSize = 50;
        private const int BoardWidth = 10;
        private const int BoardHeight = 8;
        private const int Spacing = 100;

        public MainWindow()
        {
            InitializeComponent();

            CreateBoard();
        }

        // Creates the tiles
        private void CreateBoard()
        {
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Ellipse spot = new Ellipse();
                    spot.Width = 10;
                    spot.Height = 10;

                    Canvas.SetLeft(spot, Spacing * x);
                    Canvas.SetTop(spot, Spacing * y);

                    spot.Fill = Brushes.Black;
                    GameBoard.Children.Add(spot);
                }
                

            }
            
        }
        private void GameBoard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mousePosition = e.GetPosition(GameBoard);
            MessageBox.Show($"X: {mousePosition.X}, Y: {mousePosition.Y}");
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            Player.Fill = Brushes.Green;
            FightButton.IsEnabled = true;
        }

        private void FightButton_Click(object sender, RoutedEventArgs e)
        {
            // Fight logic here
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            GameOverText.Visibility = Visibility.Visible;
        }
    }
}