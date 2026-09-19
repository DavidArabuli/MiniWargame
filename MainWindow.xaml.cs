using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MiniWargame
{
    public partial class MainWindow : Window
    {
        GameManager gameManager = new GameManager();
        Board gameBoard = new Board();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void PlayButtonClick(object sender, RoutedEventArgs e)
        {
            GameMessageText.Text = "Play button clicked!";
            GameMessageText.Visibility = Visibility.Visible;
            gameManager.playGame();
            gameBoard.CreateBoard();
            foreach (GameSpot gameSpot in gameBoard.GameSpots)
            {
                Ellipse spot = new Ellipse();

                spot.Width = 20;
                spot.Height = 20;
                spot.Fill = Brushes.Black;

                Canvas.SetLeft(spot, gameSpot.X);
                Canvas.SetTop(spot, gameSpot.Y);

                GameBoard.Children.Add(spot);
            }
        }

        public void QuitButtonClick(object sender, RoutedEventArgs e)
        {
            GameMessageText.Text = "Quit button clicked!";
            GameMessageText.Visibility = Visibility.Visible;
            gameManager.endGame();
        }

        public void RestartButtonClick(object sender, RoutedEventArgs e)
        {
            GameMessageText.Text = "Restart button clicked!";
            GameMessageText.Visibility = Visibility.Visible;
            gameManager.restartGame();
        }

        public void FightButtonClick(object sender, RoutedEventArgs e)
        {
            GameMessageText.Text = "Fight button clicked!";
            GameMessageText.Visibility = Visibility.Visible;
        }

        private void GameBoard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // We will implement this later
        }
    }
}