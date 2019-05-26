 using System;

namespace ElementaryTasks
{
    public class ConsoleUI : IDraw
    {
        public void Draw(ISurface<ICell> board)
        {
            for (int i = 0; i < board.Height; i++)
            {
                for (int j = 0; j < board.Width; j++)
                {
                    if (board.Cells[i, j].IsDark == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }
                    
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
