using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Area
{
    internal class Rectangle
    {
        int width;
        int height;

        public int Width
        {
            get
            {
                return width;

            }
            set
            {
                if(value < 0)
                    width =0;
                else
                    width = value;
            }
        }

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

       


        public Rectangle()
        {
            width = 1;
            height = 1;
        }
        public Rectangle(int _Width, int _Height)
        {
            Width = _Width;
            Height = _Height;
            
        }

        public int Calc_Area()
        {
            return height * width;
        }
        ~Rectangle()
        {

        }


    }
}
