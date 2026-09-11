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

        public MainWindow()
        {
            InitializeComponent();

            CreateBoard();
        }

        // Creates the tiles
        private void CreateBoard()
        {
            for (int y = 0; y < BoardHeight; y++)
            {
                for (int x = 0; x < BoardWidth; x++)
                {
                    Border tile = new Border();

                    tile.Width = TileSize;
                    tile.Height = TileSize;

                    tile.BorderBrush = Brushes.Black;
                    tile.BorderThickness = new Thickness(1);
                    tile.Background = Brushes.LightGray;

                    Canvas.SetLeft(tile, x * TileSize);
                    Canvas.SetTop(tile, y * TileSize);

                    GameBoard.Children.Add(tile);
                    
                }
            }
            
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