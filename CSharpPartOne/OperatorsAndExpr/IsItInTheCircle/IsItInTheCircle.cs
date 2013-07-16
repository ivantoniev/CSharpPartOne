using System;


namespace IsItInTheCircle
{
    class IsItInTheCircle
    {
        static void Main()
        {
            int xCoord, yCoord, circleRad;
            xCoord = 3;
            yCoord = 2;
            circleRad = 5;
            bool statement;
            statement = (xCoord * xCoord + yCoord * yCoord) < (circleRad * circleRad);
            Console.WriteLine(statement);
        }
    }
}
