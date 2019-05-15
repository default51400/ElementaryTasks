using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementaryTasks
{
    public abstract class ChessBoard
    {
        private int _height;
        private int _width;

        public int Height
        {
            get { return _height; }
            set { _height = value; } //TODO: Add Validator value
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; } //TODO: Add Validator value
        }

        public ChessBoard(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        public ChessBoard(string[] args)
        {
            ValidatorTwoIntegerNumbers validator = new ValidatorTwoIntegerNumbers(args);
            validator.Validate();
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

        public abstract void ShowChessBoard();

    }
}