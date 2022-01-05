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
        public Square[] seq { get; set; }
        public Rectangle[] rect { get; set; }

        public Picture(Square square, Rectangle rectangle)
        {
            this.square = square;
            this.rectangle = rectangle;
        }
        public Picture(Square[] seq, Rectangle[] rect)
        {
            
            this.rect = rect;
            this.seq = seq;


        }

        public int Calculate_Pic_Area()
        {
            int area = 0;
            area = square.Calc_Area() + rectangle.Calc_Area();
            return area;
        }
        //Calculating the sum of areas
        public int Calculate_Array_Pic()
        {
            int area = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                area += seq[i].Calc_Area();
            }
            for (int i = 0; i < rect.Length; i++)
            {
                area += rect[i].Calc_Area();
            }


            return area;
        }
        //Deallocating
        ~Picture()
        {

        }
    }
}
