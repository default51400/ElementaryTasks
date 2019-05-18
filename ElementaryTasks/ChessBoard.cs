using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementaryTasks
{
    public class ChessBoard
    {
        private int _height;
        private int _width;

        public int Height
        {
            get { return _height; }
            set { _height = value; } 
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; } 
        }
        public ChessBoard()
        {
            // Default values for standart chessBoard
            Height = 8; 
            Width = 8;
        }
        public ChessBoard(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        public ChessBoard(string[] args)
        {
            Validator.IsValid(args);
            this.Height = int.Parse(args[0]);
            this.Width = int.Parse(args[1]);
        }

        //private int GreaterZero(int side)
        //{
        //    if (side < 0)
        //    {
        //        //throw new ArgumentOutOfRangeException("Input args must be > 0");
        //    }
        //    else
        //    {
        //        return side;
        //    }

        //}

    }
}