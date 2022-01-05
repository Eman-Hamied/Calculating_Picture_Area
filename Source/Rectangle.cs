using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Area
{
    //Inherited Class from Shape
    internal class Rectangle:Shape
    {
        int height;
        public int Height
        {
            get
            {
                return height;

            }
            set
            {
                if (value < 0)
                    height = 0;
                else
                    height = value;
            }
        }  

        //Constructor
        public Rectangle()
        { 
            height = 1;
        }
        public Rectangle(int _X,int _Height) : base(_X)
        {
            Height = _Height;
            
        }

        //Function to Calculate Area
        public override int Calc_Area()
        {
            return height * Side;
        }

        //Deallocating
        ~Rectangle()
        {

        }


    }
}
