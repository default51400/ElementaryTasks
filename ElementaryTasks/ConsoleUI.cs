using System;

namespace ElementaryTasks
{
    public class ConsoleUI : IDraw
    {
        public void Draw(ISurface board)
        {
            //TODO: Add ICell[,], and set Color of cell
            for (int i = 1; i <= board.Height; i++)
            {
                for (int j = 1; j <= board.Width; j++)
                {
                    if (i % 2 == 1)
                        if (j % 2 == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                        }
                    else
                    if (j % 2 == 1)
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
