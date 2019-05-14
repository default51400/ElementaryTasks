using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementaryTasks
{
    abstract class ChessBoard
    {
        private int height;
        private int width;

        public int Height
        {
            get { return height; }
            set { height = value; } //TODO: Add Validator value
        }
        public int Width
        {
            get { return width; }
            set { width = value; } //TODO: Add Validator value
        }

        public ChessBoard(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        public ChessBoard(string[] args)
        {
            if (int.TryParse(args[0], out int width) && int.TryParse(args[1], out int height))
            {
                Width = width;
                Height = height;
            }
            else
            {
                throw new  ArgumentException("Invalid input args");
            }
        }

        public abstract void ShowChessBoard();

    }
}