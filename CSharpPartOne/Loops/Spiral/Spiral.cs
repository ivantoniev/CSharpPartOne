using System;

namespace Spiral
{
    class Spiral
    {
        static void Main()
        {
            
            Console.WriteLine("Enter the size of your matrix.");
            int size = int.Parse(Console.ReadLine());
            int sizeTwo = size;
            int[,] myArr = new int [size,size];
            Console.WriteLine("Enter the numbers of your matrix.");
            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < sizeTwo; cols++)
                {
                    myArr[rows, cols] = int.Parse(Console.ReadLine());
                }
            }
            int startrow = 0, endrow = size - 1;
            int startcol = 0, endcol = sizeTwo - 1;
            while (startrow <= endrow && startcol <= endcol)
            {
                for (int j = startcol; j <= endcol; j++)              
                    Console.Write(myArr[startrow, j]);
                    startrow++;
                    
               for (int i = startrow; i <= endrow; i++)
                    Console.Write(myArr[i, endcol]);
                    endcol--;
                   
               for (int k = endcol; k >= startcol; k--)                      
                   Console.Write(myArr[endrow, k]);
                   endrow--;
                   
               for (int l = endrow; l >= startrow; l--)                          
                   Console.Write(myArr[l, startcol]);
                   startcol++;
                   
            }
        }
    }
}
