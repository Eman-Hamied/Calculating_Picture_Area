using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Area
{
    //Inherited Class from shape
    internal class Square:Shape
    {

        //Function to Calculate square area
        public override int Calc_Area()
        {
            return Side * Side;
        }

        //Constuctor
        public Square(int _X) : base(_X) { }

        //Deallocating
        ~Square()
        { 
        }
    }
}
