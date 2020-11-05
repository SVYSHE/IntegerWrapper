using System;

namespace IntegerWrapper
{
    class main
    {
        public static void Main()
        {
            TInteger firstInt = new TInteger(5);
            TInteger secondInt = new TInteger(4);

            Console.WriteLine(firstInt.Addition(secondInt).IntValue);
            Console.WriteLine(firstInt.Subtraktion(secondInt).IntValue);
            Console.WriteLine(firstInt.Multiplikation(secondInt).IntValue);
            Console.WriteLine(firstInt.Division(secondInt).IntValue);
            Console.ReadKey();
        }
    }
}
