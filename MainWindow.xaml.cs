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
        private List<GameSpot> gameSpots = new List<GameSpot>();
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
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    int spotX = x * Spacing;
                    int spotY = y * Spacing;

                    GameSpot gameSpot = new GameSpot();
                    gameSpot.X = spotX;
                    gameSpot.Y = spotY;
                    gameSpots.Add(gameSpot);

                    Ellipse spot = new Ellipse();
                    spot.Width = 20;
                    spot.Height = 20;
                    spot.Fill = Brushes.Black;

                    Canvas.SetLeft(spot, spotX);
                    Canvas.SetTop(spot, spotY);

                    GameBoard.Children.Add(spot);
                }
            }
        }
        class GameSpot
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        private void GameBoard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mousePosition = e.GetPosition(GameBoard);

            foreach (GameSpot gameSpot in gameSpots)
            {
                double distanceX = mousePosition.X - gameSpot.X;
                double distanceY = mousePosition.Y - gameSpot.Y;

                double distance = Math.Sqrt(
                    distanceX * distanceX +
                    distanceY * distanceY
                );

                if (distance < 50)
                {
                    Canvas.SetLeft(Player, gameSpot.X - Player.Width / 2 + 10);
                    Canvas.SetTop(Player, gameSpot.Y - Player.Height / 2 + 10);

                    break;
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