using System;

namespace Picture_Area
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Rectangle rect = new Rectangle(5, 4);
            Square seq = new Square(5);
            Picture pic = new Picture(seq,rect);

            Console.WriteLine("Picture Area = "+pic.Calculate_Pic_Area());

            Rectangle[] rect2 = new Rectangle[2];
            Square[] seq2 = new Square[2];
            
            //Squares and rectangles to array
            rect2[0]=rect;
            rect2[1] = rect;
            seq2[0]=seq;
            seq2[1] = seq;
            //creating new picture that takes two arrays
            Picture pic2 = new Picture(seq2, rect2);

            //printing
            Console.WriteLine("Picture Area Array " + pic2.Calculate_Array_Pic());
        }
    }
}