using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Area
{
    //This class is to calculate the whole picture area consists of squares and rectangles
    internal class Picture
    {
        public Square square { get; set; }
        public Rectangle rectangle { get; set; }
 
        public Shape[] shape { get; set; }

        //Constructor
        public Picture (Shape[] shape)
        {
            this.shape = shape;
        }

        public int Calculate_Pic_Area()
        {
            int area = 0;
            area = square.Calc_Area() + rectangle.Calc_Area();
            return area;
        }

        ///Calculating the sum of areas
        public int Calculate_Total()
        {
            int area = 0;
            for (int i = 0; i <shape.Length ; i++)
            {
                area += shape[i].Calc_Area();
            }
            return area;
        }
        //Deallocting
        ~Picture()
        {

        }
    }
}
