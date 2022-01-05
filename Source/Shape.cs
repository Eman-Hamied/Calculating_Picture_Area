using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Area
{
    //This class is the parent class for shapes in this project
    abstract internal class Shape
    {
        int side;
        public int Side
        {
            get
            {
                return side;

            }
            set
            {
                if (value < 0)
                    side = 0;
                else
                    side = value;
            }

        }

        //Constructors
        public Shape()
        {
            side = 1;
        }
        public Shape(int _X)
        {
            side = _X;
        }


        abstract public int Calc_Area();
    }
}
