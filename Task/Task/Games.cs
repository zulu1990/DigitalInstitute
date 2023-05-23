namespace Task
{
    public abstract class Game
    {
        protected string _name;
        protected int _playerCount;

        public Game(string name, int playerCount)
        {
            _name = name;
            _playerCount = playerCount;
        }

        public abstract void Play();
    }

    public class TicTacToe : Game
    {
        public TicTacToe() : base("Tic-Tac-Toe", 2)
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Playing {_name} with {_playerCount} players");

            #region Game Logic

            char[,] board = new char[3, 3];
            char currentPlayer = 'X';
            bool gameWon = false;
            InitializeBoard();

            Console.WriteLine("Welcome to Tic Tac Toe!");

            while (!gameWon)
            {
                PrintBoard();
                Console.WriteLine($"Player {currentPlayer}'s turn. Enter the row (0-2):");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter the column (0-2):");
                int column = Convert.ToInt32(Console.ReadLine());

                if (IsValidMove(row, column))
                {
                    MakeMove(row, column);
                    CheckWinningCondition();
                    SwitchPlayer();
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }

            PrintBoard();
            Console.WriteLine($"Player {currentPlayer} wins the game!");
            void InitializeBoard()
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int column = 0; column < 3; column++)
                    {
                        board[row, column] = '-';
                    }
                }
            }

            void PrintBoard()
            {
                Console.WriteLine("Board:");
                for (int row = 0; row < 3; row++)
                {
                    for (int column = 0; column < 3; column++)
                    {
                        Console.Write(board[row, column] + " ");
                    }
                    Console.WriteLine();
                }
            }

            bool IsValidMove(int row, int column)
            {
                if (row >= 0 && row < 3 && column >= 0 && column < 3 && board[row, column] == '-')
                {
                    return true;
                }
                return false;
            }

            void MakeMove(int row, int column)
            {
                board[row, column] = currentPlayer;
            }

            void CheckWinningCondition()
            {
                // Check rows
                for (int row = 0; row < 3; row++)
                {
                    if (board[row, 0] != '-' && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                    {
                        gameWon = true;
                        return;
                    }
                }

                // Check columns
                for (int column = 0; column < 3; column++)
                {
                    if (board[0, column] != '-' && board[0, column] == board[1, column] && board[1, column] == board[2, column])
                    {
                        gameWon = true;
                        return;
                    }
                }

                // Check diagonals
                if (board[0, 0] != '-' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    gameWon = true;
                    return;
                }

                if (board[0, 2] != '-' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    gameWon = true;
                    return;
                }

                // Check for a tie
                bool tie = true;
                for (int row = 0; row < 3; row++)
                {
                    for (int column = 0; column < 3; column++)
                    {
                        if (board[row, column] == '-')
                        {
                            tie = false;
                            break;
                        }
                    }
                }

                if (tie)
                {
                    gameWon = true;
                    Console.WriteLine("It's a tie!");
                }
            }

            void SwitchPlayer()
            {
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }

            #endregion

            Console.WriteLine("Tic-Tac-Toe game in progress...");
            Console.WriteLine("Game over! Winner: Player 1");
        }
    }

    public class Chess : Game
    {
        public Chess() : base("Chess", 2)
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Playing {_name} with {_playerCount} players");
            // Chess game logic 
            Console.WriteLine("Chess game in progress...");
            Console.WriteLine("Game over! Winner: Player 2");
        }
    }

    public class SnakeAndLadder : Game
    {
        public SnakeAndLadder(int playerCount) : base("Snake and Ladder", playerCount)
        {
        }

        public override void Play()
        {
            Console.WriteLine($"Playing {_name} with {_playerCount} players");
            Console.WriteLine("Snake and Ladder game in progress...");
            #region Game Logic

            int[] playerPositions;
            int[] diceValues;
            bool[] isPlayerFinished;
            int playerCount;
            bool gameOver;

            playerCount = _playerCount;
            playerPositions = new int[playerCount];
            diceValues = new int[playerCount];
            isPlayerFinished = new bool[playerCount];
            gameOver = false;

            Console.WriteLine("Welcome to Snake and Ladder Game!");
            Console.WriteLine("Number of players: " + playerCount);

            while (!gameOver)
            {
                for (int i = 0; i < playerCount; i++)
                {
                    if (!isPlayerFinished[i])
                    {
                        RollDice(i);
                        MovePlayer(i);
                        CheckWinningCondition(i);

                        if (gameOver)
                            break;
                    }
                }
            }

            void RollDice(int playerIndex)
            {
                Random random = new Random();
                diceValues[playerIndex] = random.Next(1, 7);
                Console.WriteLine("Player " + (playerIndex + 1) + " rolled a " + diceValues[playerIndex]);
            }

            void MovePlayer(int playerIndex)
            {
                playerPositions[playerIndex] += diceValues[playerIndex];
                Console.WriteLine("Player " + (playerIndex + 1) + " current position: " + playerPositions[playerIndex]);
            }

            void CheckWinningCondition(int playerIndex)
            {
                if (playerPositions[playerIndex] >= 100)
                {
                    gameOver = true;
                    isPlayerFinished[playerIndex] = true;
                }
            }

            int GetWinningPlayer()
            {
                for (int i = 0; i < playerCount; i++)
                {
                    if (playerPositions[i] >= 100)
                        return i + 1;
                }
                return -1;
            }

            Console.WriteLine("Congratulations! Player " + GetWinningPlayer() + " wins the game!");
            #endregion
        }
    }
}
