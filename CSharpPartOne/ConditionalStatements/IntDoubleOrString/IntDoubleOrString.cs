using System;

namespace IntDoubleOrString
{
    class IntDoubleOrString
    {
        static void Main()
        {
            Console.WriteLine("Enter the the type you wish: integer, double or string.");
            string types = Console.ReadLine();
            switch (types)
            {
                case "integer": 
                    {
                        int firstVar = int.Parse(Console.ReadLine());
                        Console.WriteLine(firstVar+1);
                        break;
                    }
                case "double":
                    {
                        double secondVar = double.Parse(Console.ReadLine());
                        Console.WriteLine(secondVar + 1);
                        break;
                    }
                case "string":
                    {
                        string thirdVar = Console.ReadLine();
                        Console.WriteLine(thirdVar + '*');
                        break;
                    }

            }
        }
    }
}
