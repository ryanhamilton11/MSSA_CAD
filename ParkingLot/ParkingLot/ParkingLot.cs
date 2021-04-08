using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class ParkingLot
    {
        //FIELDS
        private int _large = 3;
        private int _medium = 5;
        private int _small = 10;

        //CONSTRUCTORS
        public ParkingLot(int large, int medium, int small)
        {
            _large = large;
            _medium = medium;
            _small = small;
        }


        //METHODS
        public bool AddCar(string carType)
        {
            if (carType == "Large")
            {
                _large -= 1;
                if (_large >= 1)
                {
                    return true;
                }
                else return false;
            }
            else if (carType == "Medium")
            {
                _medium -= 1;
                if (_medium >= 1)
                {
                    return true;
                }
                else return false;
            }
            else if (carType == "Small")
            {
                _small -= 1;
                if (_small >= 1)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
}
