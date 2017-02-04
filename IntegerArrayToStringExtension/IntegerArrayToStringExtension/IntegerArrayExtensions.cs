namespace IntegerArrayToStringExtension
{
    public static class IntegerArrayExtensions
    {
        public static string IntegerArrayToStringExtension(this int[] array, string separator)
        {
            return string.Join(separator, array);
        }
    }
}
