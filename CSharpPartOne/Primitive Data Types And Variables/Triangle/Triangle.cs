using System;
using System.Text;

namespace ProblemSeven
{
    class Triangle
    {
        static void Main()
        {
            char myChar;
            myChar = '©';
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(@"
     {0}
   {0}  {0}
  {0}    {0}
 {0} {0} {0} {0}", myChar);       
        }
    }
}
