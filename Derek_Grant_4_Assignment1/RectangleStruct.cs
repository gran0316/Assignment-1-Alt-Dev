using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Derek_Grant_4_Assignment1
{
    class RectangleStruct
    {
        #region Fields
        //Create the fields without initializing. 
        public int _width;
        public int _height;
        #endregion

        #region Properties
        //Method to set and get the value of PositionStruct.width.
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        //Method to set and get te values of PositionStruct.height.
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        #endregion

        #region Contructor
        //With a struct you are given a default constructor with no paramaters, therefore you need to make one.

        public RectangleStruct(int width, int height)
        {
            this._width = width;
            this._height = height;
        }
        #endregion

    }
}
