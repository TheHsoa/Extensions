using System;

namespace IntegerArrayToStringExtension
{
    internal class Program
    {
        private static void Main()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            var arrayLength = random.Next(10, 100);
            var array = new int[arrayLength];

            for (var i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            Console.WriteLine(array.IntegerArrayToStringExtension("; "));

            Console.ReadKey();
        }
    }
}
