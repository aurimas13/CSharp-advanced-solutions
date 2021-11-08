// Created by Aurimas A. Nausedas on 08/18/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;

namespace Properties
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);
            ////box.length = 3;
            //box.SetLength(5);
            //box.Height = -4; // property access
            //box.Width = 4;

            Console.WriteLine("Box's width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box's width is " + box.Width);
            Console.WriteLine("Box's length is " + box.GetLength());
            Console.WriteLine("Box's height is " + box.Height);
            Console.WriteLine("Box's volume is " + box.Volume);
            Console.WriteLine("Front surface of the box is {0}", box.FrontSurface);
            box.DisplayInfo();
        }
    }
}
