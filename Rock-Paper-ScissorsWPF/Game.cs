using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_ScissorsWPF
{
    public enum Move { Stone, Paper, Scissors }

    public class Game
    {
        private Random random = new Random();

        public Move GetComputerMove()
        {
            return (Move)random.Next(0, 3);
        }

        public string GetResult(Move playerMove, Move computerMove)
        {
            switch (playerMove)
            {
                case Move.Stone:
                    switch (computerMove)
                    {
                        case Move.Stone:
                            return "Ничья!";
                        case Move.Scissors:
                            return "Вы выиграли!";
                        case Move.Paper:
                            return "Компьютер выиграл!";
                    }
                    break;

                case Move.Paper:
                    switch (computerMove)
                    {
                        case Move.Stone:
                            return "Вы выиграли!";
                        case Move.Scissors:
                            return "Компьютер выиграл!";
                        case Move.Paper:
                            return "Ничья!";
                    }
                    break;

                case Move.Scissors:
                    switch (computerMove)
                    {
                        case Move.Stone:
                            return "Компьютер выиграл!";
                        case Move.Scissors:
                            return "Ничья!";
                        case Move.Paper:
                            return "Вы выиграли!";
                    }
                    break;
            }
            return "";
        }
    }
}
