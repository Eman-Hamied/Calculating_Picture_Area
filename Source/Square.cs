using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Area
{
    //Square class contains ine integer property ,Constructors adn function
    internal class Square
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


        public Square(int _Side)
        {
            side = _Side;
        }

        public Square()
        {
            side = 1;
        }

        //Function to Calculate square area
        public int Calc_Area()
        {
            return side * side;
        }

        //Deallocating 
        ~Square()
        { 
        }
    }
}
