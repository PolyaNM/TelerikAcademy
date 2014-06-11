using System;
using System.Collections.Generic;

namespace _04.Minesweeper
{
	public class Game
	{
        private const int BoardRows = 5;
        private const int BoardColumns = 10;
	    private const int MaxScore = 35;
	    private const int MaxHighScoresToDisplay = 6;
		static void Main()
		{
            char[,] field = CreatePlayField();
            char[,] bombs = CreateMineField();
			string command = string.Empty;
            List<Score> topScores = new List<Score>(MaxHighScoresToDisplay);

			int counter = 0;		         
			int row = 0;
			int column = 0;
			bool startPosition = true;
            bool isBomb = false;  
			bool reachedMaxScore = false;

			do
			{
				if (startPosition)
				{
					Console.WriteLine("Let`s play Minesweeper! Try to find all cells without mines in order to clear the field. \nCommands:\n" +
					"1.Command 'top' - shows the high scores. \n2.Command 'restart' restarts the game. \n3.Command 'exit' - closes the game.");
					PrintBoard(field);
					startPosition = false;
				}
				Console.Write("Choose row and column : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out column) &&
						row <= field.GetLength(0) && column <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						PrintTopScores(topScores);
						break;
					case "restart":
						field = CreatePlayField();
						bombs = CreateMineField();
						PrintBoard(field);
						isBomb = false;
						startPosition = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (bombs[row, column] != '*')
						{
							if (bombs[row, column] == '-')
							{
								UpdateBoard(field, bombs, row, column);
								counter++;
							}
							if (MaxScore == counter)
							{
								reachedMaxScore = true;
							}
							else
							{
								PrintBoard(field);
							}
						}
						else
						{
							isBomb = true;
						}
						break;
					default:
						Console.WriteLine("\nError! Invalid command\n");
						break;
				}
				if (isBomb)
				{
					PrintBoard(bombs);
					Console.Write("\nGAME OVER! Score: {0} points. " +
						"\nEnter your nickname: ", counter);
					string nickname = Console.ReadLine();
					Score newScore = new Score(nickname, counter);
					if (topScores.Count < 5)
					{
						topScores.Add(newScore);
					}
					else
					{
						for (int i = 0; i < topScores.Count; i++)
						{
							if (topScores[i].Points < newScore.Points)
							{
								topScores.Insert(i, newScore);
								topScores.RemoveAt(topScores.Count - 1);
								break;
							}
						}
					}
					topScores.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
					topScores.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
					PrintTopScores(topScores);

					field = CreatePlayField();
					bombs = CreateMineField();
					counter = 0;
					isBomb = false;
					startPosition = true;
				}
				if (reachedMaxScore)
				{
					Console.WriteLine("\nWIN! Well Done :).");
					PrintBoard(bombs);
					Console.WriteLine("Enter your nickname: ");
					string nickname = Console.ReadLine();
                    Score newScore = new Score(nickname, counter);
					topScores.Add(newScore);
					PrintTopScores(topScores);
					field = CreatePlayField();
					bombs = CreateMineField();
					counter = 0;
					reachedMaxScore = false;
					startPosition = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}
        /// <summary>
        /// Prints the top scores of the players.
        /// </summary>
        /// <param name="points">the list with the scores</param>
		private static void PrintTopScores(List<Score> points)
		{
			Console.WriteLine("\nTop Scores:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} points",
						i + 1, points[i].Name, points[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("No highscores so far!:)\n");
			}
		}

		private static void UpdateBoard(char[,] field,
			char[,] bombs, int row, int column)
		{
            char kolkoBombi = CountAdjacentMines(bombs, row, column);
            bombs[row, column] = kolkoBombi;
            field[row, column] = kolkoBombi;
		}

		private static void PrintBoard(char[,] board)
		{
			int boardRows = board.GetLength(0);
			int boradCols = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < boardRows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < boradCols; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreatePlayField()
		{
			char[,] board = new char[BoardRows, BoardColumns];
			for (int i = 0; i < BoardRows; i++)
			{
				for (int j = 0; j < BoardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

        private static char[,] CreateMineField()
		{
			char[,] mineField = new char[BoardRows, BoardColumns];

            for (int i = 0; i < BoardRows; i++)
			{
                for (int j = 0; j < BoardColumns; j++)
				{
					mineField[i, j] = '-';
				}
			}

			List<int> randomNumbers = new List<int>();
			while (randomNumbers.Count < 15)
			{
				Random random = new Random();
				int asfd = random.Next(50);
				if (!randomNumbers.Contains(asfd))
				{
					randomNumbers.Add(asfd);
				}
			}

			foreach (int number in randomNumbers)
			{
                int col = (number / BoardColumns);
                int row = (number % BoardColumns);
				if (row == 0 && number != 0)
				{
					col--;
                    row = BoardColumns;
				}
				else
				{
					row++;
				}
				mineField[col, row - 1] = '*';
			}

			return mineField;
		}

        private static char CountAdjacentMines(char[,] mineField, int row, int col)
		{
			int counter = 0;
			int rows = mineField.GetLength(0);
			int cols = mineField.GetLength(1);

			if (row - 1 >= 0)
			{
				if (mineField[row - 1, col] == '*')
				{ 
					counter++; 
				}
			}
			if (row + 1 < rows)
			{
				if (mineField[row + 1, col] == '*')
				{ 
					counter++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (mineField[row, col - 1] == '*')
				{ 
					counter++;
				}
			}
			if (col + 1 < cols)
			{
				if (mineField[row, col + 1] == '*')
				{ 
					counter++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (mineField[row - 1, col - 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (mineField[row - 1, col + 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (mineField[row + 1, col - 1] == '*')
				{ 
					counter++; 
				}
			}
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (mineField[row + 1, col + 1] == '*')
				{ 
					counter++; 
				}
			}
			return char.Parse(counter.ToString());
		}
	}
}
