using System;

namespace Picture_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape rect = new Rectangle(5, 4);
            Shape seq = new Square(5);
 
            Shape sh = new Square(3);
            Shape sh2 = new Rectangle(6,7);
            Shape[] sh3 = new Shape[4];
            sh3[0] = rect;
            sh3[1] = seq;
            sh3[2] = sh;
            sh3[3] = sh2;


            Picture pic = new Picture(sh3);
            Console.WriteLine("Picture Area = " + pic.Calculate_Total());


        }
    }
}