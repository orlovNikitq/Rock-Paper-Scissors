using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rock_Paper_ScissorsWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int playerScore = 0;
        private int computerScore = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_start_Click(object sender, RoutedEventArgs e)
        {
            bt_start.Visibility = Visibility.Hidden;
            bt_Paper.Visibility = Visibility.Visible;
            bt_Stone.Visibility = Visibility.Visible;
            bt_Scissors.Visibility = Visibility.Visible;
        }
        private void UpdateScore(string result)
        {
            if (result == "Вы выиграли!")
            {
                playerScore++;
                lb_you.Content = $"{playerScore}";
            }
            else if (result == "Компьютер выиграл!")
            {
                computerScore++;
                lb_ii.Content = $"{computerScore}";
            }
        }

        private void bt_Stone_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            Move playerMove = Move.Stone;
            Move computerMove = game.GetComputerMove();
            string result = game.GetResult(playerMove, computerMove);
            UpdateScore(result);
            MessageBox.Show(result);
        }

        private void bt_Scissors_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            Move playerMove = Move.Scissors;
            Move computerMove = game.GetComputerMove();
            string result = game.GetResult(playerMove, computerMove);
            UpdateScore(result);
            MessageBox.Show(result);
        }

        private void bt_Paper_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            Move playerMove = Move.Paper;
            Move computerMove = game.GetComputerMove();
            string result = game.GetResult(playerMove, computerMove);
            UpdateScore(result);
            MessageBox.Show(result);
        }
    }
}
