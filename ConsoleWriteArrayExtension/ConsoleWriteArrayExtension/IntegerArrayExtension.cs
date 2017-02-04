using System;

namespace ConsoleWriteArrayExtension
{
    public static class IntegerArrayExtension
    {
        public static void WriteIntegerArray(this int[] array)
        {
            foreach (var value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
 