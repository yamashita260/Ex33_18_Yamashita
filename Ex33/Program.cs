using System;

namespace Ex33
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(3, 5);
            RectAngle rectAngle2 = new RectAngle(2, 4);

            if(rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }

            RectAngle rectAngle3 = rectAngle1+ rectAngle2;
            Console.WriteLine($"2つの長方形が入る長方形は({rectAngle3.width},{rectAngle3.height})\n面積は({rectAngle3.height * rectAngle3.width})");
        }
    }
}