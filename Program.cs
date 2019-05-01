using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string name in args )
            {
                int i = int.Parse(name);
                if( i%2 == 0)
                {
                Console.WriteLine(i);
                }
            }
        }
    }
}
