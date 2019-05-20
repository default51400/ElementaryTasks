using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementaryTasks
{
    public class ChessBoard : IBoard
    {
        private const int DEFAULT_HEIGHT = 8;
        private const int DEFAULT_WIDTH = 8;
        private int _height;
        private int _width;

        public int Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }
        public int Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            } 
        }
        public ChessBoard():this(DEFAULT_HEIGHT, DEFAULT_WIDTH)
        {
        }
        public ChessBoard(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
    }
}