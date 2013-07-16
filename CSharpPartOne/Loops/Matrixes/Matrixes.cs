using System;

namespace Matrixes
{
    class Matrixes
    {
        static void Main()
        {
            Console.WriteLine("Enter the dimentions of the matrix.");
            int dims = int.Parse(Console.ReadLine());
            for (int row = 1; row < dims+1; row++)
            {
                Console.WriteLine();
                for (int col = row; col < row + dims; col++)
                {
                    Console.Write("{0,2}",col);
                }
                Console.WriteLine();
            }
        }
    }
}
