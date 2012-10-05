using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Derek_Grant_4_Assignment1
{
    class PositionStruct
    {
        #region Fields
        //Create the fields without initializing. 
        public int _positionX;
        public int _positionY;
        #endregion

        #region Properties

        //Method to set and get the values of position X.
        public int PositionX
        {
            get
            {
                return _positionX;
            }
            set
            {
                _positionX = value;
            }
        }

        //Method to set and get te values of position Y.
        public int PositionY
        {
            get
            {
                return _positionY;
            }
            set
            {
                _positionY = value;
            }
        }

        #endregion

        #region Contructor
        //With a struct you are given a default constructor with no paramaters, therefore you need to make one.

        public PositionStruct(int positionX, int positionY)
        {
            this._positionX = positionX;
            this._positionY = positionY;
        }
        #endregion
    }
}
