using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElementaryTasks
{
    public class ChessBoard : ISurface
    {
        #region Fields & CONST
        private const int DEFAULT_HEIGHT = 8;
        private const int DEFAULT_WIDTH = 8;
        private int _height;
        private int _width;
        #endregion

        #region Props
        public int Height
        {
            get { return _height; }
            set
            {
                _height = Validate(value);
            }
        }
        public int Width
        {
            get { return _width; }
            set
            {
                _width = Validate(value);
            }
        }
        #endregion

        #region Ctors
        public ChessBoard() : this(DEFAULT_HEIGHT, DEFAULT_WIDTH)
        {
        }
        public ChessBoard(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }
        #endregion

        private int Validate(int side)
        {
            if ((side > 0) && (side <= 2147483647))
            {
                return side;
            }
            else throw new ArgumentException("The value length of sides must be set in a segment: 0 < value < 2147483647");
        }

    }
}