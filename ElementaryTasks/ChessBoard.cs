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
            set { _height = Validate(value); } 
        }
        public int Width
        {
            get { return _width; }
            set { _width = Validate(value); } 
        }
        public ChessBoard()
        {
        }
        public ChessBoard(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        public ChessBoard(string[] args)
        {
            //ValidatorTwoIntegerNumbers validator = new ValidatorTwoIntegerNumbers(args);
            //validator.Validate();
            //if (int.TryParse(args[0], out int width) && int.TryParse(args[1], out int height))
            //{
            //    this.Width = width;
            //    this.Height = height;
            //}
            //else
            //{
            //    throw new  ArgumentException("Invalid input args");
            //    //TODO: Добавить вызов инструкции
            //}
        }
        private int Validate(int side)
        {
            if (side <= 0)
            {
                throw new ArgumentOutOfRangeException("Input args must be >=0");
            }

            return side;
        }
        public virtual void ShowChessBoard()
        {

        }

    }
}