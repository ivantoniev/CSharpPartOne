using System;

namespace IsItIn
{
    class IsItIn
    {
        static void Main()
        {
            double xCoord, yCoord, circleRad;
            xCoord = 2;
            yCoord = 0.5;
            circleRad = 3;
            bool inRect=((xCoord<=5 && xCoord>=(-1)) && (yCoord>=(-1)&&yCoord<=1));
            bool inCircle=(xCoord*xCoord+yCoord*yCoord)<=(circleRad*circleRad-2);
            Console.WriteLine("Is it in the rectangle? {0}",inRect);
            Console.WriteLine("Is it in the circle? {0}",inCircle);
        }
    }
}
