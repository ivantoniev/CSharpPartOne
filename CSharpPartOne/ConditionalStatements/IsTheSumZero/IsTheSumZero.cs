using System;
namespace IsTheSumZero
{
    class IsTheSumZero
    {
        static void Main()
        {
            int i, j;
            int[] myArr = new int[5];
            for (i = 0; i < 5; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 4; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    {
                        if (myArr[i] + myArr[j] == 0)
                        {
                            if (myArr[j] < 0)
                            {
                                Console.WriteLine("{0} {1}=0", myArr[i], myArr[j]);
                            }
                            else
                            {
                                Console.WriteLine("{0} + {1}=0", myArr[i], myArr[j]);
                            }
                        }
                    }
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = i + 1; j < 4; j++)
                {
                    for (int k = j + 1; k < 5; k++)
                    {
                        if (myArr[i] + myArr[j] + myArr[k] == 0)
                        {
                            if(myArr[j]<0)
                            {
                            Console.WriteLine("{0} {1} + {2}=0", myArr[i], myArr[j], myArr[k]);
                            }
                            if (myArr[k] < 0)
                            {
                                Console.WriteLine("{0} + {1} {2}=0", myArr[i], myArr[j], myArr[k]);
                            }
                            Console.WriteLine("{0} + {1} + {2}=0", myArr[i], myArr[j], myArr[k]);
                        }
                    }
                }
            }
            for (i = 0; i < 2; i++)
            {
                for (j = i + 1; j < 3; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        for (int l = k + 1; l < 5; l++)
                        {
                            if (myArr[i] + myArr[j] + myArr[k] + myArr[l] == 0)
                            {
                                if (myArr[j]<0)
                                {
                                    Console.WriteLine("{0} {1} + {2} + {3}=0", myArr[i], myArr[j], myArr[k], myArr[l]);
                                }
                                if (myArr[k] < 0)
                                {
                                    Console.WriteLine("{0} + {1} {2} + {3}=0", myArr[i], myArr[j], myArr[k], myArr[l]);
                                }
                                if (myArr[l] < 0)
                                {
                                    Console.WriteLine("{0} + {1} + {2} {3}=0", myArr[i], myArr[j], myArr[k], myArr[l]);
                                } 
                                Console.WriteLine("{0} + {1} + {2} + {3}=0", myArr[i], myArr[j], myArr[k], myArr[l]);
                            }
                        }

                    }
                }
            }
            if ((myArr[0] + myArr[1] + myArr[2] + myArr[3] + myArr[4]) == 0)
            {
                if (myArr[1] < 0)
                {
                    Console.WriteLine("{0} {1} + {2} + {3} + {4}=0", myArr[0], myArr[1], myArr[2], myArr[3], myArr[4]);
                }
                if (myArr[2] < 0)
                {
                    Console.WriteLine("{0} + {1} {2} + {3} + {4}=0", myArr[0], myArr[1], myArr[2], myArr[3], myArr[4]);
                }
                if (myArr[3] < 0)
                {
                    Console.WriteLine("{0} + {1} + {2} {3} + {4}=0", myArr[0], myArr[1], myArr[2], myArr[3], myArr[4]);
                }
                if (myArr[4] < 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} + {4}=0", myArr[0], myArr[1], myArr[2], myArr[3], myArr[4]);
                }
                Console.WriteLine("{0} + {1} + {2} + {3} + {4}=0", myArr[0], myArr[1], myArr[2], myArr[3], myArr[4]);
            }
        }
    }
}
