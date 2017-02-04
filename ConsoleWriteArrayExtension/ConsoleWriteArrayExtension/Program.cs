using System;

//  Задание из лекции 11, сайд 14
namespace ConsoleWriteArrayExtension
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

            array.WriteIntegerArray();

            Console.ReadKey();
        }
    }
}
